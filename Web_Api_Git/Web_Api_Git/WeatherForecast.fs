namespace Web_Api_Git

open System

type WeatherForecast =
    { Date: DateTime
      TemperatureC: int
      Summary: string }

    member this.TemperatureF =
        32.0 + (float this.TemperatureC / 0.5556)
