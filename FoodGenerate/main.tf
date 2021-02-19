provider "heroku" {
  version = "~> 2.0"
}

variable "app_name" {
  default = "FoodGenerate"
}

resource "heroku_app" "FoodGenerate" {
  name   = "${var.app_name}"
  region = "us"
  stack  = "container"
}

resource "heroku_build" "FoodGenerate" {
  app = "${heroku_app.FoodGenerate.name}"
  source = {
    path = "./"
  }
}

output "app_url" {
  value = "https://${heroku_app.myweb.name}.herokuapp.com"
}