using BPMNUtils.Models.Common;
using BPMNUtils.Models.Process.Data;

namespace BPMNUtils.Models.Process.Activities
{
    public class MultiInstanceLoopCharacteristics : LoopCharacteristics
    {

        /// <summary>
        /// A numeric Expression that controls the number of Activity instances
        ///        that will be created.This Expression MUST evaluate to an integer.
        ///This MAY be underspecified, meaning that the modeler MAY simply document
        ///        the condition.In such a case the loop cannot be formally
        ///        executed.
        ///In order to initialize a valid multi-instance, either the loopCardinality
        ///        Expression or the loopDataInput MUST be specified.
        /// </summary>
        public virtual Expression LoopCardinality { get; set; }

        /// <summary>
        /// This ItemAwareElement is used to determine the number of Activity
        ///        instances, one Activity instance per item in the collection of data stored
        ///in that ItemAwareElement element.
        ///For Tasks it is a reference to a Data Input which is part of the Activity’s
        ///InputOutputSpecification.
        ///For Sub-Processes it is a reference to a collection-valued Data Object
        ///in the context that is visible to the Sub-Processes.
        ///In order to initialize a valid multi-instance, either the loopCardinality
        ///Expression or the loopDataInput MUST be specified.
        /// </summary>
        public virtual IItemAwareElement LoopDataInputRef { get; set; }

        /// <summary>
        /// This ItemAwareElement specifies the collection of data, which will be
        ///  produced by the multi-instance.
        ///  For Tasks it is a reference to a Data Output which is part of the
        ///  Activity’s InputOutputSpecification.
        ///  For Sub-Processes it is a reference to a collection-valued Data Object
        ///  in the context that is visible to the Sub-Processes.
        /// </summary>
        public virtual IItemAwareElement LoopDataOutputRef { get; set; }

        /// <summary>
        /// A Data Input, representing for every Activity instance the single item of
        ///  the collection stored in the loopDataInput.This Data Input can be
        ///  the source of DataInputAssociation to a data input of the Activity’s
        ///  InputOutputSpecification. The type of this Data Input MUST the
        ///  scalar of the type defined for the loopDataInput.
        /// </summary>
        public virtual DataInput InputDataItem { get; set; }

        /// <summary>
        /// A Data Output, representing for every Activity instance the single item
        ///of the collection stored in the loopDataOutput.This Data Output can
        ///be the target of DataOutputAssociation to a data output of the
        ///Activity’s InputOutputSpecification. The type of this Data
        ///Output MUST the scalar of the type defined for the loopDataOutput
        /// </summary>
        public virtual DataOutput OutputDataItem { get; set; }

      
        /// <summary>
        /// This attribute defines a boolean Expression that when evaluated to
        /// true, cancels the remaining Activity instances and produces a token.
        /// </summary>
        public virtual Expression CompletionCondition { get; set; }

        /// <summary>
        /// This attribute is a flag that controls whether the Activity instances will
        /// execute sequentially or in parallel.
        /// </summary>
        public virtual bool IsSequential { get; set; } = false;

        /// <summary>
        /// The attribute behavior acts as a shortcut for specifying when events
        ///        SHALL be thrown from an Activity instance that is about to complete.It
        ///        can assume values of None, One, All, and Complex, resulting in the
        ///        following behavior:
        ///• None: the EventDefinition which is associated through the
        ///noneEvent association will be thrown for each instance
        ///completing.
        ///• One: the EventDefinition referenced through the oneEvent
        ///association will be thrown upon the first instance completing.
        ///• All: no Event is ever thrown; a token is produced after completion
        ///of all instances.
        ///• Complex: the complexBehaviorDefinitions are consulted to
        ///determine if and which Events to throw.
        ///For the behaviors of none and one, a default
        ///SignalEventDefinition will be thrown which automatically carries
        ///the current runtime attributes of the MI Activity.
        ///Any thrown Events can be caught by boundary Events on the Multi-
        ///Instance Activity.
        /// </summary>
        public virtual MultiInstanceBehavior Behavior { get; set; } = MultiInstanceBehavior.All;

        /// <summary>
        /// The EventDefinition which is thrown when behavior is set to one
        /// and the first internal Activity instance has completed.
        /// </summary>
        public virtual EventDefinition OneBehaviorEventRef { get; set; }

        /// <summary>
        /// The EventDefinition which is thrown when the behavior is set to
        /// none and an internal Activity instance has completed.
        /// </summary>
        public virtual EventDefinition NoneBehaviorEventRef { get; set; }
    }
}
