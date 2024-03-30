using Microsoft.AspNetCore.Builder;
using VirtualVenuePro;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<VirtualVenueProWebTestModule>();

public partial class Program
{
}
