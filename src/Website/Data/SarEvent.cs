﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kcesar.MissionLine.Website.Data
{
  public class SarEvent
  {
    public SarEvent()
    {
      this.SignIns = new List<MemberSignIn>();
      this.Calls = new List<VoiceCall>();
    }

    public int Id { get; set; }
    public string Name { get; set; }

    public DateTime Opened { get; set; }
    public DateTime? Closed { get; set; }

    public string OutgoingText { get; set; }
    public string OutgoingUrl { get; set; }

    public string DirectionsText { get; set; }
    public string DirectionsUrl { get; set; }

    public virtual ICollection<MemberSignIn> SignIns { get; set; }
    public virtual ICollection<VoiceCall> Calls { get; set; }
  }
}