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
using Amazon.IoTDeviceAdvisor;
using Amazon.IoTDeviceAdvisor.Model;

namespace Amazon.PowerShell.Cmdlets.IOTDA
{
    /// <summary>
    /// Creates a Device Advisor test suite.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateSuiteDefinition</a>
    /// action.
    /// </para>
    /// </summary>
    [Cmdlet("New", "IOTDASuiteDefinition", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.IoTDeviceAdvisor.Model.CreateSuiteDefinitionResponse")]
    [AWSCmdlet("Calls the AWS IoT Core Device Advisor CreateSuiteDefinition API operation.", Operation = new[] {"CreateSuiteDefinition"}, SelectReturnType = typeof(Amazon.IoTDeviceAdvisor.Model.CreateSuiteDefinitionResponse))]
    [AWSCmdletOutput("Amazon.IoTDeviceAdvisor.Model.CreateSuiteDefinitionResponse",
        "This cmdlet returns an Amazon.IoTDeviceAdvisor.Model.CreateSuiteDefinitionResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewIOTDASuiteDefinitionCmdlet : AmazonIoTDeviceAdvisorClientCmdlet, IExecutor
    {
        
        #region Parameter SuiteDefinitionConfiguration_DevicePermissionRoleArn
        /// <summary>
        /// <para>
        /// <para>Gets the device permission ARN.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SuiteDefinitionConfiguration_DevicePermissionRoleArn { get; set; }
        #endregion
        
        #region Parameter SuiteDefinitionConfiguration_Device
        /// <summary>
        /// <para>
        /// <para>Gets the devices configured.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SuiteDefinitionConfiguration_Devices")]
        public Amazon.IoTDeviceAdvisor.Model.DeviceUnderTest[] SuiteDefinitionConfiguration_Device { get; set; }
        #endregion
        
        #region Parameter SuiteDefinitionConfiguration_IntendedForQualification
        /// <summary>
        /// <para>
        /// <para>Gets the tests intended for qualification in a suite.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? SuiteDefinitionConfiguration_IntendedForQualification { get; set; }
        #endregion
        
        #region Parameter SuiteDefinitionConfiguration_RootGroup
        /// <summary>
        /// <para>
        /// <para>Gets test suite root group.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SuiteDefinitionConfiguration_RootGroup { get; set; }
        #endregion
        
        #region Parameter SuiteDefinitionConfiguration_SuiteDefinitionName
        /// <summary>
        /// <para>
        /// <para>Gets Suite Definition Configuration name.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SuiteDefinitionConfiguration_SuiteDefinitionName { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>The tags to be attached to the suite definition.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public System.Collections.Hashtable Tag { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.IoTDeviceAdvisor.Model.CreateSuiteDefinitionResponse).
        /// Specifying the name of a property of type Amazon.IoTDeviceAdvisor.Model.CreateSuiteDefinitionResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.SuiteDefinitionConfiguration_SuiteDefinitionName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-IOTDASuiteDefinition (CreateSuiteDefinition)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.IoTDeviceAdvisor.Model.CreateSuiteDefinitionResponse, NewIOTDASuiteDefinitionCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            context.SuiteDefinitionConfiguration_DevicePermissionRoleArn = this.SuiteDefinitionConfiguration_DevicePermissionRoleArn;
            if (this.SuiteDefinitionConfiguration_Device != null)
            {
                context.SuiteDefinitionConfiguration_Device = new List<Amazon.IoTDeviceAdvisor.Model.DeviceUnderTest>(this.SuiteDefinitionConfiguration_Device);
            }
            context.SuiteDefinitionConfiguration_IntendedForQualification = this.SuiteDefinitionConfiguration_IntendedForQualification;
            context.SuiteDefinitionConfiguration_RootGroup = this.SuiteDefinitionConfiguration_RootGroup;
            context.SuiteDefinitionConfiguration_SuiteDefinitionName = this.SuiteDefinitionConfiguration_SuiteDefinitionName;
            if (this.Tag != null)
            {
                context.Tag = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.Tag.Keys)
                {
                    context.Tag.Add((String)hashKey, (String)(this.Tag[hashKey]));
                }
            }
            
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
            var request = new Amazon.IoTDeviceAdvisor.Model.CreateSuiteDefinitionRequest();
            
            
             // populate SuiteDefinitionConfiguration
            var requestSuiteDefinitionConfigurationIsNull = true;
            request.SuiteDefinitionConfiguration = new Amazon.IoTDeviceAdvisor.Model.SuiteDefinitionConfiguration();
            System.String requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_DevicePermissionRoleArn = null;
            if (cmdletContext.SuiteDefinitionConfiguration_DevicePermissionRoleArn != null)
            {
                requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_DevicePermissionRoleArn = cmdletContext.SuiteDefinitionConfiguration_DevicePermissionRoleArn;
            }
            if (requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_DevicePermissionRoleArn != null)
            {
                request.SuiteDefinitionConfiguration.DevicePermissionRoleArn = requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_DevicePermissionRoleArn;
                requestSuiteDefinitionConfigurationIsNull = false;
            }
            List<Amazon.IoTDeviceAdvisor.Model.DeviceUnderTest> requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_Device = null;
            if (cmdletContext.SuiteDefinitionConfiguration_Device != null)
            {
                requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_Device = cmdletContext.SuiteDefinitionConfiguration_Device;
            }
            if (requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_Device != null)
            {
                request.SuiteDefinitionConfiguration.Devices = requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_Device;
                requestSuiteDefinitionConfigurationIsNull = false;
            }
            System.Boolean? requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_IntendedForQualification = null;
            if (cmdletContext.SuiteDefinitionConfiguration_IntendedForQualification != null)
            {
                requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_IntendedForQualification = cmdletContext.SuiteDefinitionConfiguration_IntendedForQualification.Value;
            }
            if (requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_IntendedForQualification != null)
            {
                request.SuiteDefinitionConfiguration.IntendedForQualification = requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_IntendedForQualification.Value;
                requestSuiteDefinitionConfigurationIsNull = false;
            }
            System.String requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_RootGroup = null;
            if (cmdletContext.SuiteDefinitionConfiguration_RootGroup != null)
            {
                requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_RootGroup = cmdletContext.SuiteDefinitionConfiguration_RootGroup;
            }
            if (requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_RootGroup != null)
            {
                request.SuiteDefinitionConfiguration.RootGroup = requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_RootGroup;
                requestSuiteDefinitionConfigurationIsNull = false;
            }
            System.String requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_SuiteDefinitionName = null;
            if (cmdletContext.SuiteDefinitionConfiguration_SuiteDefinitionName != null)
            {
                requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_SuiteDefinitionName = cmdletContext.SuiteDefinitionConfiguration_SuiteDefinitionName;
            }
            if (requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_SuiteDefinitionName != null)
            {
                request.SuiteDefinitionConfiguration.SuiteDefinitionName = requestSuiteDefinitionConfiguration_suiteDefinitionConfiguration_SuiteDefinitionName;
                requestSuiteDefinitionConfigurationIsNull = false;
            }
             // determine if request.SuiteDefinitionConfiguration should be set to null
            if (requestSuiteDefinitionConfigurationIsNull)
            {
                request.SuiteDefinitionConfiguration = null;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
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
        
        private Amazon.IoTDeviceAdvisor.Model.CreateSuiteDefinitionResponse CallAWSServiceOperation(IAmazonIoTDeviceAdvisor client, Amazon.IoTDeviceAdvisor.Model.CreateSuiteDefinitionRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS IoT Core Device Advisor", "CreateSuiteDefinition");
            try
            {
                #if DESKTOP
                return client.CreateSuiteDefinition(request);
                #elif CORECLR
                return client.CreateSuiteDefinitionAsync(request).GetAwaiter().GetResult();
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
            public System.String SuiteDefinitionConfiguration_DevicePermissionRoleArn { get; set; }
            public List<Amazon.IoTDeviceAdvisor.Model.DeviceUnderTest> SuiteDefinitionConfiguration_Device { get; set; }
            public System.Boolean? SuiteDefinitionConfiguration_IntendedForQualification { get; set; }
            public System.String SuiteDefinitionConfiguration_RootGroup { get; set; }
            public System.String SuiteDefinitionConfiguration_SuiteDefinitionName { get; set; }
            public Dictionary<System.String, System.String> Tag { get; set; }
            public System.Func<Amazon.IoTDeviceAdvisor.Model.CreateSuiteDefinitionResponse, NewIOTDASuiteDefinitionCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
