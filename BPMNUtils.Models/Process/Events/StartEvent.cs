﻿
using BPMNUtils.Models.Common;

namespace BPMNUtils.Models.Process.Events
{
    /// <summary>
    /// As the name implies, the Start Event indicates where a particular Process will start. In terms of Sequence Flows, the
    /// Start Event starts the flow of the Process, and thus, will not have any incoming Sequence Flows—no Sequence
    /// Flow can connect to a Start Event.
    /// </summary>
    public class StartEvent : CatchEvent
    {
        /// <summary>
        /// This attribute only applies to Start Events of Event Sub-Processes; it is ignored for
        /// other Start Events.This attribute denotes whether the Sub-Process encompassing
        /// the Event Sub-Process should be cancelled or not, If the encompassing Sub-
        /// Process is not cancelled, multiple instances of the Event Sub-Process can run
        /// concurrently.This attribute cannot be applied to Error Events (where it’s always
        /// true), or Compensation Events(where it doesn’t apply).
        /// </summary>
        public virtual bool IsInterrupting { get; set; }

    }
}
