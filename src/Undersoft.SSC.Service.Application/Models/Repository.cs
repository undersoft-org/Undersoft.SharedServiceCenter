﻿using Undersoft.SSC.Domain.Entities.Enums;
using Undersoft.SSC.Service.Contracts;

namespace Undersoft.SSC.Service.Application.Models;

public class Repository : Member, IModel
{
    public Repository() { Group = MemberGroup.Servitizer; }

}
