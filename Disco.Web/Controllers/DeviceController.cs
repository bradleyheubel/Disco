﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Disco.BI;
using Disco.BI.Extensions;
using Disco.Data.Repository;
using Disco.Models.Repository;
using System.Data.Objects.SqlClient;
using Disco.Web.Extensions;


namespace Disco.Web.Controllers
{
    public partial class DeviceController : dbAdminController
    {
        #region Index
        public virtual ActionResult Index()
        {
            return View();
        }
        #endregion

        #region Add Offline
        public virtual ActionResult AddOffline()
        {
            var m = new Models.Device.AddOfflineModel()
            {
                DefaultDeviceProfileId = dbContext.DiscoConfiguration.DeviceProfiles.DefaultAddDeviceOfflineDeviceProfileId
            };
            m.DeviceBatches = dbContext.DeviceBatches.ToSelectListItems();
            m.DeviceProfiles = dbContext.DeviceProfiles.ToList();
            if (m.DefaultDeviceProfileId == 0)
            {
                m.DeviceProfiles.Insert(0, new DeviceProfile() { Id = 0, Name = "Select a Device Profile" });
            }

            return View(m);
        }
        [HttpPost]
        public virtual ActionResult AddOffline(Models.Device.AddOfflineModel m)
        {
            // Trim Serial Number & Error Check
            m.Device.SerialNumber = m.Device.SerialNumber.Trim();
            if (string.IsNullOrEmpty(m.Device.SerialNumber))
            {
                ModelState.AddModelError("Device.SerialNumber", "The Serial Number is Required");
            }
            else
            {
                // Ensure Existing Device Doesn't Exist
                if (!string.IsNullOrEmpty(m.Device.SerialNumber) && dbContext.Devices.Count(d => d.SerialNumber == m.Device.SerialNumber) > 0)
                    ModelState.AddModelError("Device.SerialNumber", "A Device what this Serial Number already exists");
            }
            

            if (ModelState.IsValid)
            {
                var d = m.Device.AddOffline(dbContext);
                dbContext.SaveChanges();
                return RedirectToAction(MVC.Device.Show(d.SerialNumber));
            }
            return AddOffline();
        }
        #endregion

        #region Show
        public virtual ActionResult Show(string id)
        {
            var m = new Models.Device.ShowModel();

            dbContext.Configuration.LazyLoadingEnabled = true;

            m.Device = dbContext.Devices
                .Where(d => d.SerialNumber == id)
                .FirstOrDefault();

            if (m.Device == null)
                throw new ArgumentException(string.Format("Unknown Device: [{0}]", id), "id");

            // Removed 2012-07-03 G#
            // Deferred to Ajax call - improve load performance
            // Update Device LastNetworkLogonDate
            //if (m.Device.UpdateLastNetworkLogonDate())
            //    dbContext.SaveChanges();

            // No Necessary - Yet...
            //if (!string.IsNullOrWhiteSpace(m.Device.ComputerName))
            //{
            //    var adMachineAccount = BI.Interop.ActiveDirectory.ActiveDirectory.GetMachineAccount(m.Device.ComputerName);
            //    if (adMachineAccount != null)
            //    {
            //        m.OrganisationUnit = adMachineAccount.ParentDistinguishedName;
            //    }
            //}

            m.DeviceProfiles = dbContext.DeviceProfiles.ToList();

            m.DeviceBatches = dbContext.DeviceBatches.ToSelectListItems(m.Device.DeviceBatchId);

            m.Jobs = new Disco.Models.BI.Job.JobTableModel() { ShowStatus = true, ShowDevice = false, IsSmallTable = true, HideClosedJobs = true };
            m.Jobs.Fill(dbContext, BI.JobBI.Searching.BuildJobTableModel(dbContext).Where(j => j.DeviceSerialNumber == m.Device.SerialNumber)); 

            m.Certificates = dbContext.DeviceCertificates.Where(c => c.DeviceSerialNumber == m.Device.SerialNumber).ToList();

            //m.AttachmentTypes = dbContext.AttachmentTypes.Where(at => at.Scope == AttachmentType.AttachmentTypeScopes.Device).ToList();
            m.DocumentTemplates = m.Device.AvailableDocumentTemplates(dbContext, DiscoApplication.CurrentUser, DateTime.Now);

            return View(m);
        }
        #endregion
    }
}
