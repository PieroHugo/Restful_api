// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Entities;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Repositories;
using CrewWeb.VehixPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using CrewWeb.VehixPlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Infrastructure.Persistence.EFC.Repositories;

public class BadPracticeRepository(AppDbContext context) : BaseRepository<BadPractice>(context), IBadPracticeRepository;
