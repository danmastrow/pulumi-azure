// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Waf.Outputs
{

    [OutputType]
    public sealed class PolicyCustomRuleMatchCondition
    {
        /// <summary>
        /// Match value
        /// </summary>
        public readonly ImmutableArray<string> MatchValues;
        /// <summary>
        /// One or more `match_variable` block defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.PolicyCustomRuleMatchConditionMatchVariable> MatchVariables;
        /// <summary>
        /// Describes if this is negate condition or not
        /// </summary>
        public readonly bool? NegationCondition;
        /// <summary>
        /// Describes operator to be matched
        /// </summary>
        public readonly string Operator;

        [OutputConstructor]
        private PolicyCustomRuleMatchCondition(
            ImmutableArray<string> matchValues,

            ImmutableArray<Outputs.PolicyCustomRuleMatchConditionMatchVariable> matchVariables,

            bool? negationCondition,

            string @operator)
        {
            MatchValues = matchValues;
            MatchVariables = matchVariables;
            NegationCondition = negationCondition;
            Operator = @operator;
        }
    }
}