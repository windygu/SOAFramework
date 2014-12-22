﻿using SOAFramework.Service.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using System.Windows.Forms;
using SOAFramework.Service.Server;
using SOAFramework.Library;

namespace SOAFramework.Server.UI
{
    public partial class ServerUI : BaseUI
    {
        public ServerUI()
        {
            InitializeComponent();
            tbStart.Click += tbStart_Click;
            tbStop.Click += tbStop_Click;
            tbStop.Enabled = false;
        }

        private Task hostTask;
        private WebServiceHost host; 

        private void tbStart_Click(object sender, EventArgs e)
        {
            host = new WebServiceHost(typeof(SOAService));
            if (host != null)
            {
                hostTask = new Task(() =>
                {
                    host.Open();
                });
                hostTask.Start();
                tbStart.Enabled = false;
                tbStop.Enabled = true;
                MonitorCache.GetInstance().PushMessage(new CacheMessage { Message = "服务器已启动" });
            }
        }

        private void tbStop_Click(object sender, EventArgs e)
        {
            if (host != null && host.State == System.ServiceModel.CommunicationState.Opened)
            {
                host.Close(); 
                tbStart.Enabled = true;
                tbStop.Enabled = false;
                MonitorCache.GetInstance().PushMessage(new CacheMessage { Message = "服务器已停止" });
            }
        }
    }
}
