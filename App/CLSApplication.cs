// <copyright file="CLSApplication.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.App
{
	using System.Windows.Forms;

	using FindAndReplace.Core.DataStructures;
	using FindAndReplace.Core.Ports.Incoming;
	using FindAndReplace.Core.Ports.Outgoing;
	using FindAndReplace.Core.Services;
	using FindAndReplace.Presentation.ConsoleApp;
	using FindAndReplace.SecondaryAdapters;

	using Microsoft.Extensions.DependencyInjection;
	using Microsoft.Extensions.Hosting;

	internal class CLSApplication
	{
		private IHostBuilder objHostBuilder;
		private IHost objHost;
		private CLSInstanceSettings objInstanceSettings;
		private FRMGui frmGUI;

		public CLSApplication(CLSInstanceSettings p_objInstanceSettings)
		{
			this.objInstanceSettings = p_objInstanceSettings;
			this.subLoadSettings();
			this.subConfigureDatabases();
			this.subConfigureLogging();

			if (this.objInstanceSettings.vbnRunAsGUIApp)
			{
				this.subConfigureUI();
			}

			this.subCreateHost();
		}

		public void subStart()
		{
			this.subStartApplication();
		}

		public void subStartAsync()
		{
			this.subStartApplication(true);
		}

		public void subStop()
		{
			this.subStopApplication();
		}

		public void subStopAsync()
		{
			this.subStopApplication(true);
		}

		public T fncGetService<T>()
		{
			using (IServiceScope objScope = this.objHost.Services.CreateScope())
			{
				return objScope.ServiceProvider.GetRequiredService<T>();
			}
		}

		private void subOnFormClosed(object sender, FormClosedEventArgs objEventArgs)
		{
			// TODO: Remove the following line.
			System.Console.WriteLine("External Form Closed Event Handler Called");
			this.subStopApplication();
		}

		private void subStartApplication(bool p_vbnAsync = false)
		{
			if (p_vbnAsync)
			{
				this.objHost.StartAsync();
			}
			else
			{
				this.objHost.Start();
			}

			if (this.objInstanceSettings.vbnRunAsGUIApp)
			{
				IFCBulkSearch objBulkSearch = this.objHost.Services.GetRequiredService<IFCBulkSearch>();
				IFCStringReplaceWithOptions objStringReplaceWithOptions = this.objHost.Services.GetRequiredService<IFCStringReplaceWithOptions>();
				IFCCsvManagement objCsvManagement = this.objHost.Services.GetRequiredService<IFCCsvManagement>();
				this.frmGUI = new FRMGui(objBulkSearch, objStringReplaceWithOptions, objCsvManagement);
				this.frmGUI.FormClosed += this.subOnFormClosed;
				Application.Run(this.frmGUI); // Calls frmGui.Show() internally.
			}
		}

		private void subStopApplication(bool p_vbnAsync = false)
		{
			if (p_vbnAsync)
			{
				this.objHost.StopAsync();
			}
			else
			{
				this.objHost.StopAsync().Wait();
			}
		}

		private void subCreateHost(string[]? p_aryArguments = null)
		{
			// Create host builder
			this.objHostBuilder = Host.CreateDefaultBuilder(p_aryArguments);

			// Configure services
			this.objHostBuilder.ConfigureServices(this.subRegisterServices);

			// Build and return host
			this.objHost = this.objHostBuilder.Build();
		}

		private void subConfigureDatabases()
		{
			// Configure databases
		}

		private void subConfigureLogging()
		{
			// Configure logging
		}

		private void subRegisterServices(IServiceCollection p_objServices)
		{
			// Configure services
			// p_objServices.Add...

			// Helper services
			p_objServices.AddTransient<IFCReadFile, CLSReadFile>();
			p_objServices.AddTransient<IFCReadFolder, CLSReadFolder>();
			p_objServices.AddTransient<IFCWriteFile, CLSWriteFile>();

			// Core services
			p_objServices.AddSingleton<IFCStringReplaceWithOptions, CLSStringReplaceWithOptions>();
			p_objServices.AddSingleton<IFCBulkSearch, CLSBulkSearch>();
		}

		private void subConfigureUI()
		{
			// Configure UI

			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
		}

		private void subLoadSettings()
		{
			// Load settings from config file
		}
	}
}
