﻿using Settings;
using Settings.Schema;

namespace UnitTests
{
	public class TestContext
	{
		public ISchemaBuilder Builder { get; } = new SchemaBuilder();

		public ISettingsSchema Schema { get; set; }

		public IResolver Resolver { get; set; }
	}
}