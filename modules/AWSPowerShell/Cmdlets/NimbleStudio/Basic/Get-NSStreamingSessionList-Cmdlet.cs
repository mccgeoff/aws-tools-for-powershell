/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.NimbleStudio;
using Amazon.NimbleStudio.Model;

namespace Amazon.PowerShell.Cmdlets.NS
{
    /// <summary>
    /// Lists the streaming image resources in a studio.
    /// </summary>
    [Cmdlet("Get", "NSStreamingSessionList")]
    [OutputType("Amazon.NimbleStudio.Model.StreamingSession")]
    [AWSCmdlet("Calls the Amazon Nimble Studio ListStreamingSessions API operation.", Operation = new[] {"ListStreamingSessions"}, SelectReturnType = typeof(Amazon.NimbleStudio.Model.ListStreamingSessionsResponse))]
    [AWSCmdletOutput("Amazon.NimbleStudio.Model.StreamingSession or Amazon.NimbleStudio.Model.ListStreamingSessionsResponse",
        "This cmdlet returns a collection of Amazon.NimbleStudio.Model.StreamingSession objects.",
        "The service call response (type Amazon.NimbleStudio.Model.ListStreamingSessionsResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetNSStreamingSessionListCmdlet : AmazonNimbleStudioClientCmdlet, IExecutor
    {
        
        #region Parameter CreatedBy
        /// <summary>
        /// <para>
        /// <para>Filters the request to streaming sessions created by the given user.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String CreatedBy { get; set; }
        #endregion
        
        #region Parameter OwnedBy
        /// <summary>
        /// <para>
        /// <para>Filters the request to streaming session owned by the given user</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String OwnedBy { get; set; }
        #endregion
        
        #region Parameter SessionId
        /// <summary>
        /// <para>
        /// <para>Filters the request to only the provided session IDs.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SessionIds")]
        public System.String SessionId { get; set; }
        #endregion
        
        #region Parameter StudioId
        /// <summary>
        /// <para>
        /// <para>The studio ID. </para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String StudioId { get; set; }
        #endregion
        
        #region Parameter NextToken
        /// <summary>
        /// <para>
        /// <para>The token to request the next page of results. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NextToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Sessions'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.NimbleStudio.Model.ListStreamingSessionsResponse).
        /// Specifying the name of a property of type Amazon.NimbleStudio.Model.ListStreamingSessionsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Sessions";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the StudioId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^StudioId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^StudioId' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.NimbleStudio.Model.ListStreamingSessionsResponse, GetNSStreamingSessionListCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.StudioId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.CreatedBy = this.CreatedBy;
            context.NextToken = this.NextToken;
            context.OwnedBy = this.OwnedBy;
            context.SessionId = this.SessionId;
            context.StudioId = this.StudioId;
            #if MODULAR
            if (this.StudioId == null && ParameterWasBound(nameof(this.StudioId)))
            {
                WriteWarning("You are passing $null as a value for parameter StudioId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.NimbleStudio.Model.ListStreamingSessionsRequest();
            
            if (cmdletContext.CreatedBy != null)
            {
                request.CreatedBy = cmdletContext.CreatedBy;
            }
            if (cmdletContext.NextToken != null)
            {
                request.NextToken = cmdletContext.NextToken;
            }
            if (cmdletContext.OwnedBy != null)
            {
                request.OwnedBy = cmdletContext.OwnedBy;
            }
            if (cmdletContext.SessionId != null)
            {
                request.SessionIds = cmdletContext.SessionId;
            }
            if (cmdletContext.StudioId != null)
            {
                request.StudioId = cmdletContext.StudioId;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.NimbleStudio.Model.ListStreamingSessionsResponse CallAWSServiceOperation(IAmazonNimbleStudio client, Amazon.NimbleStudio.Model.ListStreamingSessionsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Nimble Studio", "ListStreamingSessions");
            try
            {
                #if DESKTOP
                return client.ListStreamingSessions(request);
                #elif CORECLR
                return client.ListStreamingSessionsAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public System.String CreatedBy { get; set; }
            public System.String NextToken { get; set; }
            public System.String OwnedBy { get; set; }
            public System.String SessionId { get; set; }
            public System.String StudioId { get; set; }
            public System.Func<Amazon.NimbleStudio.Model.ListStreamingSessionsResponse, GetNSStreamingSessionListCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Sessions;
        }
        
    }
}
