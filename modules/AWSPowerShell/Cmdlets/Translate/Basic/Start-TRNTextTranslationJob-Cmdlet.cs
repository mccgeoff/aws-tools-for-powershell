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
using Amazon.Translate;
using Amazon.Translate.Model;

namespace Amazon.PowerShell.Cmdlets.TRN
{
    /// <summary>
    /// Starts an asynchronous batch translation job. Batch translation jobs can be used to
    /// translate large volumes of text across multiple documents at once. For more information,
    /// see <a>async</a>.
    /// 
    ///  
    /// <para>
    /// Batch translation jobs can be described with the <a>DescribeTextTranslationJob</a>
    /// operation, listed with the <a>ListTextTranslationJobs</a> operation, and stopped with
    /// the <a>StopTextTranslationJob</a> operation.
    /// </para><note><para>
    /// Amazon Translate does not support batch translation of multiple source languages at
    /// once.
    /// </para></note>
    /// </summary>
    [Cmdlet("Start", "TRNTextTranslationJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.Translate.Model.StartTextTranslationJobResponse")]
    [AWSCmdlet("Calls the Amazon Translate StartTextTranslationJob API operation.", Operation = new[] {"StartTextTranslationJob"}, SelectReturnType = typeof(Amazon.Translate.Model.StartTextTranslationJobResponse))]
    [AWSCmdletOutput("Amazon.Translate.Model.StartTextTranslationJobResponse",
        "This cmdlet returns an Amazon.Translate.Model.StartTextTranslationJobResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class StartTRNTextTranslationJobCmdlet : AmazonTranslateClientCmdlet, IExecutor
    {
        
        #region Parameter InputDataConfig_ContentType
        /// <summary>
        /// <para>
        /// <para>Describes the format of the data that you submit to Amazon Translate as input. You
        /// can specify one of the following multipurpose internet mail extension (MIME) types:</para><ul><li><para><code>text/html</code>: The input data consists of one or more HTML files. Amazon
        /// Translate translates only the text that resides in the <code>html</code> element in
        /// each file.</para></li><li><para><code>text/plain</code>: The input data consists of one or more unformatted text
        /// files. Amazon Translate translates every character in this type of input.</para></li><li><para><code>application/vnd.openxmlformats-officedocument.wordprocessingml.document</code>:
        /// The input data consists of one or more Word documents (.docx).</para></li><li><para><code>application/vnd.openxmlformats-officedocument.presentationml.presentation</code>:
        /// The input data consists of one or more PowerPoint Presentation files (.pptx).</para></li><li><para><code>application/vnd.openxmlformats-officedocument.spreadsheetml.sheet</code>: The
        /// input data consists of one or more Excel Workbook files (.xlsx).</para></li><li><para><code>application/x-xliff+xml</code>: The input data consists of one or more XML
        /// Localization Interchange File Format (XLIFF) files (.xlf). Amazon Translate supports
        /// only XLIFF version 1.2.</para></li></ul><important><para>If you structure your input data as HTML, ensure that you set this parameter to <code>text/html</code>.
        /// By doing so, you cut costs by limiting the translation to the contents of the <code>html</code>
        /// element in each file. Otherwise, if you set this parameter to <code>text/plain</code>,
        /// your costs will cover the translation of every character.</para></important>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String InputDataConfig_ContentType { get; set; }
        #endregion
        
        #region Parameter DataAccessRoleArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of an AWS Identity Access and Management (IAM) role
        /// that grants Amazon Translate read access to your input data. For more information,
        /// see <a>identity-and-access-management</a>.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String DataAccessRoleArn { get; set; }
        #endregion
        
        #region Parameter EncryptionKey_Id
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the encryption key being used to encrypt the custom
        /// terminology.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("OutputDataConfig_EncryptionKey_Id")]
        public System.String EncryptionKey_Id { get; set; }
        #endregion
        
        #region Parameter JobName
        /// <summary>
        /// <para>
        /// <para>The name of the batch translation job to be performed.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String JobName { get; set; }
        #endregion
        
        #region Parameter ParallelDataName
        /// <summary>
        /// <para>
        /// <para>The name of a parallel data resource to add to the translation job. This resource
        /// consists of examples that show how you want segments of text to be translated. When
        /// you add parallel data to a translation job, you create an <i>Active Custom Translation</i>
        /// job. </para><para>This parameter accepts only one parallel data resource.</para><note><para>Active Custom Translation jobs are priced at a higher rate than other jobs that don't
        /// use parallel data. For more information, see <a href="http://aws.amazon.com/translate/pricing/">Amazon
        /// Translate pricing</a>.</para></note><para>For a list of available parallel data resources, use the <a>ListParallelData</a> operation.</para><para>For more information, see <a>customizing-translations-parallel-data</a>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ParallelDataNames")]
        public System.String[] ParallelDataName { get; set; }
        #endregion
        
        #region Parameter InputDataConfig_S3Uri
        /// <summary>
        /// <para>
        /// <para>The URI of the AWS S3 folder that contains the input file. The folder must be in the
        /// same Region as the API endpoint you are calling.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String InputDataConfig_S3Uri { get; set; }
        #endregion
        
        #region Parameter OutputDataConfig_S3Uri
        /// <summary>
        /// <para>
        /// <para>The URI of the S3 folder that contains a translation job's output file. The folder
        /// must be in the same Region as the API endpoint that you are calling.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String OutputDataConfig_S3Uri { get; set; }
        #endregion
        
        #region Parameter SourceLanguageCode
        /// <summary>
        /// <para>
        /// <para>The language code of the input language. For a list of language codes, see <a>what-is-languages</a>.</para><para>Amazon Translate does not automatically detect a source language during batch translation
        /// jobs.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String SourceLanguageCode { get; set; }
        #endregion
        
        #region Parameter TargetLanguageCode
        /// <summary>
        /// <para>
        /// <para>The language code of the output language.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [Alias("TargetLanguageCodes")]
        public System.String[] TargetLanguageCode { get; set; }
        #endregion
        
        #region Parameter TerminologyName
        /// <summary>
        /// <para>
        /// <para>The name of a custom terminology resource to add to the translation job. This resource
        /// lists examples source terms and the desired translation for each term.</para><para>This parameter accepts only one custom terminology resource.</para><para>For a list of available custom terminology resources, use the <a>ListTerminologies</a>
        /// operation.</para><para>For more information, see <a>how-custom-terminology</a>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TerminologyNames")]
        public System.String[] TerminologyName { get; set; }
        #endregion
        
        #region Parameter EncryptionKey_Type
        /// <summary>
        /// <para>
        /// <para>The type of encryption key used by Amazon Translate to encrypt custom terminologies.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("OutputDataConfig_EncryptionKey_Type")]
        [AWSConstantClassSource("Amazon.Translate.EncryptionKeyType")]
        public Amazon.Translate.EncryptionKeyType EncryptionKey_Type { get; set; }
        #endregion
        
        #region Parameter ClientToken
        /// <summary>
        /// <para>
        /// <para>A unique identifier for the request. This token is auto-generated when using the Amazon
        /// Translate SDK.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Translate.Model.StartTextTranslationJobResponse).
        /// Specifying the name of a property of type Amazon.Translate.Model.StartTextTranslationJobResponse will result in that property being returned.
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
            
            var resourceIdentifiersText = string.Empty;
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Start-TRNTextTranslationJob (StartTextTranslationJob)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Translate.Model.StartTextTranslationJobResponse, StartTRNTextTranslationJobCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            context.ClientToken = this.ClientToken;
            context.DataAccessRoleArn = this.DataAccessRoleArn;
            #if MODULAR
            if (this.DataAccessRoleArn == null && ParameterWasBound(nameof(this.DataAccessRoleArn)))
            {
                WriteWarning("You are passing $null as a value for parameter DataAccessRoleArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.InputDataConfig_ContentType = this.InputDataConfig_ContentType;
            #if MODULAR
            if (this.InputDataConfig_ContentType == null && ParameterWasBound(nameof(this.InputDataConfig_ContentType)))
            {
                WriteWarning("You are passing $null as a value for parameter InputDataConfig_ContentType which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.InputDataConfig_S3Uri = this.InputDataConfig_S3Uri;
            #if MODULAR
            if (this.InputDataConfig_S3Uri == null && ParameterWasBound(nameof(this.InputDataConfig_S3Uri)))
            {
                WriteWarning("You are passing $null as a value for parameter InputDataConfig_S3Uri which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.JobName = this.JobName;
            context.EncryptionKey_Id = this.EncryptionKey_Id;
            context.EncryptionKey_Type = this.EncryptionKey_Type;
            context.OutputDataConfig_S3Uri = this.OutputDataConfig_S3Uri;
            #if MODULAR
            if (this.OutputDataConfig_S3Uri == null && ParameterWasBound(nameof(this.OutputDataConfig_S3Uri)))
            {
                WriteWarning("You are passing $null as a value for parameter OutputDataConfig_S3Uri which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.ParallelDataName != null)
            {
                context.ParallelDataName = new List<System.String>(this.ParallelDataName);
            }
            context.SourceLanguageCode = this.SourceLanguageCode;
            #if MODULAR
            if (this.SourceLanguageCode == null && ParameterWasBound(nameof(this.SourceLanguageCode)))
            {
                WriteWarning("You are passing $null as a value for parameter SourceLanguageCode which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.TargetLanguageCode != null)
            {
                context.TargetLanguageCode = new List<System.String>(this.TargetLanguageCode);
            }
            #if MODULAR
            if (this.TargetLanguageCode == null && ParameterWasBound(nameof(this.TargetLanguageCode)))
            {
                WriteWarning("You are passing $null as a value for parameter TargetLanguageCode which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.TerminologyName != null)
            {
                context.TerminologyName = new List<System.String>(this.TerminologyName);
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
            var request = new Amazon.Translate.Model.StartTextTranslationJobRequest();
            
            if (cmdletContext.ClientToken != null)
            {
                request.ClientToken = cmdletContext.ClientToken;
            }
            if (cmdletContext.DataAccessRoleArn != null)
            {
                request.DataAccessRoleArn = cmdletContext.DataAccessRoleArn;
            }
            
             // populate InputDataConfig
            var requestInputDataConfigIsNull = true;
            request.InputDataConfig = new Amazon.Translate.Model.InputDataConfig();
            System.String requestInputDataConfig_inputDataConfig_ContentType = null;
            if (cmdletContext.InputDataConfig_ContentType != null)
            {
                requestInputDataConfig_inputDataConfig_ContentType = cmdletContext.InputDataConfig_ContentType;
            }
            if (requestInputDataConfig_inputDataConfig_ContentType != null)
            {
                request.InputDataConfig.ContentType = requestInputDataConfig_inputDataConfig_ContentType;
                requestInputDataConfigIsNull = false;
            }
            System.String requestInputDataConfig_inputDataConfig_S3Uri = null;
            if (cmdletContext.InputDataConfig_S3Uri != null)
            {
                requestInputDataConfig_inputDataConfig_S3Uri = cmdletContext.InputDataConfig_S3Uri;
            }
            if (requestInputDataConfig_inputDataConfig_S3Uri != null)
            {
                request.InputDataConfig.S3Uri = requestInputDataConfig_inputDataConfig_S3Uri;
                requestInputDataConfigIsNull = false;
            }
             // determine if request.InputDataConfig should be set to null
            if (requestInputDataConfigIsNull)
            {
                request.InputDataConfig = null;
            }
            if (cmdletContext.JobName != null)
            {
                request.JobName = cmdletContext.JobName;
            }
            
             // populate OutputDataConfig
            var requestOutputDataConfigIsNull = true;
            request.OutputDataConfig = new Amazon.Translate.Model.OutputDataConfig();
            System.String requestOutputDataConfig_outputDataConfig_S3Uri = null;
            if (cmdletContext.OutputDataConfig_S3Uri != null)
            {
                requestOutputDataConfig_outputDataConfig_S3Uri = cmdletContext.OutputDataConfig_S3Uri;
            }
            if (requestOutputDataConfig_outputDataConfig_S3Uri != null)
            {
                request.OutputDataConfig.S3Uri = requestOutputDataConfig_outputDataConfig_S3Uri;
                requestOutputDataConfigIsNull = false;
            }
            Amazon.Translate.Model.EncryptionKey requestOutputDataConfig_outputDataConfig_EncryptionKey = null;
            
             // populate EncryptionKey
            var requestOutputDataConfig_outputDataConfig_EncryptionKeyIsNull = true;
            requestOutputDataConfig_outputDataConfig_EncryptionKey = new Amazon.Translate.Model.EncryptionKey();
            System.String requestOutputDataConfig_outputDataConfig_EncryptionKey_encryptionKey_Id = null;
            if (cmdletContext.EncryptionKey_Id != null)
            {
                requestOutputDataConfig_outputDataConfig_EncryptionKey_encryptionKey_Id = cmdletContext.EncryptionKey_Id;
            }
            if (requestOutputDataConfig_outputDataConfig_EncryptionKey_encryptionKey_Id != null)
            {
                requestOutputDataConfig_outputDataConfig_EncryptionKey.Id = requestOutputDataConfig_outputDataConfig_EncryptionKey_encryptionKey_Id;
                requestOutputDataConfig_outputDataConfig_EncryptionKeyIsNull = false;
            }
            Amazon.Translate.EncryptionKeyType requestOutputDataConfig_outputDataConfig_EncryptionKey_encryptionKey_Type = null;
            if (cmdletContext.EncryptionKey_Type != null)
            {
                requestOutputDataConfig_outputDataConfig_EncryptionKey_encryptionKey_Type = cmdletContext.EncryptionKey_Type;
            }
            if (requestOutputDataConfig_outputDataConfig_EncryptionKey_encryptionKey_Type != null)
            {
                requestOutputDataConfig_outputDataConfig_EncryptionKey.Type = requestOutputDataConfig_outputDataConfig_EncryptionKey_encryptionKey_Type;
                requestOutputDataConfig_outputDataConfig_EncryptionKeyIsNull = false;
            }
             // determine if requestOutputDataConfig_outputDataConfig_EncryptionKey should be set to null
            if (requestOutputDataConfig_outputDataConfig_EncryptionKeyIsNull)
            {
                requestOutputDataConfig_outputDataConfig_EncryptionKey = null;
            }
            if (requestOutputDataConfig_outputDataConfig_EncryptionKey != null)
            {
                request.OutputDataConfig.EncryptionKey = requestOutputDataConfig_outputDataConfig_EncryptionKey;
                requestOutputDataConfigIsNull = false;
            }
             // determine if request.OutputDataConfig should be set to null
            if (requestOutputDataConfigIsNull)
            {
                request.OutputDataConfig = null;
            }
            if (cmdletContext.ParallelDataName != null)
            {
                request.ParallelDataNames = cmdletContext.ParallelDataName;
            }
            if (cmdletContext.SourceLanguageCode != null)
            {
                request.SourceLanguageCode = cmdletContext.SourceLanguageCode;
            }
            if (cmdletContext.TargetLanguageCode != null)
            {
                request.TargetLanguageCodes = cmdletContext.TargetLanguageCode;
            }
            if (cmdletContext.TerminologyName != null)
            {
                request.TerminologyNames = cmdletContext.TerminologyName;
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
        
        private Amazon.Translate.Model.StartTextTranslationJobResponse CallAWSServiceOperation(IAmazonTranslate client, Amazon.Translate.Model.StartTextTranslationJobRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Translate", "StartTextTranslationJob");
            try
            {
                #if DESKTOP
                return client.StartTextTranslationJob(request);
                #elif CORECLR
                return client.StartTextTranslationJobAsync(request).GetAwaiter().GetResult();
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
            public System.String ClientToken { get; set; }
            public System.String DataAccessRoleArn { get; set; }
            public System.String InputDataConfig_ContentType { get; set; }
            public System.String InputDataConfig_S3Uri { get; set; }
            public System.String JobName { get; set; }
            public System.String EncryptionKey_Id { get; set; }
            public Amazon.Translate.EncryptionKeyType EncryptionKey_Type { get; set; }
            public System.String OutputDataConfig_S3Uri { get; set; }
            public List<System.String> ParallelDataName { get; set; }
            public System.String SourceLanguageCode { get; set; }
            public List<System.String> TargetLanguageCode { get; set; }
            public List<System.String> TerminologyName { get; set; }
            public System.Func<Amazon.Translate.Model.StartTextTranslationJobResponse, StartTRNTextTranslationJobCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
