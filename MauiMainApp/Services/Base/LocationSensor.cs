using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Location = MauiMainApp.Models.Location;

namespace MauiMainApp.Services.Base;
internal abstract class LocationSensor : SensorService<Location> { }