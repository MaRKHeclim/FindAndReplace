namespace FindAndReplace.App
{
	using FindAndReplace.Core.DataStructures;
	using FindAndReplace.Core.Ports.Outgoing;
	using FindAndReplace.SecondaryAdapters;
	using Microsoft.Extensions.DependencyInjection;
	using Microsoft.Extensions.Hosting;

	internal class CLSApplication
	{
		private IHostBuilder objHostBuilder;
		private IHost objHost;
		private CLSInstanceSettings objInstanceSettings;

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
				Application.Run(new frmGUI());
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
			p_objServices.AddTransient<IFCReadFile, CLSReadFile>();
			p_objServices.AddTransient<IFCReadFolder, CLSReadFolder>();
			p_objServices.AddTransient<IFCWriteFile, CLSWriteFile>();
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
