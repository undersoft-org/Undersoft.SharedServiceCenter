﻿using Undersoft.SSC.Domain.Entities.Enums;
using Undersoft.SSC.Service.Contracts;

namespace Undersoft.SSC.Service.Application.Models;

public class Operation : Member, IModel
{
    public Operation() { Group = MemberGroup.Servitizer; }

}
