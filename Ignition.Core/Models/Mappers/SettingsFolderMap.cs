﻿using Glass.Mapper.Sc.Maps;
using Ignition.Foundation.Core.Factories;
using Ignition.Foundation.Core.Models.BaseModels;
using Ignition.Foundation.Core.Models.Containers;

namespace Ignition.Foundation.Core.Models.Mappers
{
	public class SettingsFolderMap : SitecoreGlassMap<ISettingsFolder>, IGlassSettingsConsumer
	{
		public override void Configure()
		{
			Map(x =>
			{
				ImportMap<IModelBase>();
				x.AutoMap().Cachable();
				x.TemplateId(SettingsFactory.GetAppSetting("Ignition.Map.Id.SettingsFolder"));
			});
		}
		public ISitecoreSettingsFactory SettingsFactory { get; set; }
	}
}