﻿/*
 * Copyright 2015 Matthew Cosand
 */
namespace Kcesar.MissionLine.Website.Api.Model
{
  using System;

  public class CallEntry
  {
    public int Id { get; set; }
    public string Number { get; set; }
    public string Name { get; set; }
    public DateTimeOffset Time { get; set; }
    public string Recording { get; set; }

    public int? EventId { get; set; }
  }
}