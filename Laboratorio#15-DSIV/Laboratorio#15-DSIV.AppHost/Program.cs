var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Laboratorio#15_2_DSIV>("laboratorio#15-2-dsiv");


builder.Build().Run();
