﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public abstract class ControllerBase  : Controller
    {
        protected Guid ClienteId = Guid.Parse("a126cd3b-059b-4a41-869a-d7a8896ff984");    //somente pra simulação. o certo seria pegar do client logado
    }
}