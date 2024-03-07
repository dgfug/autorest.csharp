// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using OpenAI;

namespace OpenAI.Models
{
    /// <summary> The FineTuningJob. </summary>
    public partial class FineTuningJob
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FineTuningJob"/>. </summary>
        /// <param name="id"> The object identifier, which can be referenced in the API endpoints. </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the fine-tuning job was created. </param>
        /// <param name="finishedAt">
        /// The Unix timestamp (in seconds) for when the fine-tuning job was finished. The value will be
        /// null if the fine-tuning job is still running.
        /// </param>
        /// <param name="model"> The base model that is being fine-tuned. </param>
        /// <param name="fineTunedModel">
        /// The name of the fine-tuned model that is being created. The value will be null if the
        /// fine-tuning job is still running.
        /// </param>
        /// <param name="organizationId"> The organization that owns the fine-tuning job. </param>
        /// <param name="status">
        /// The current status of the fine-tuning job, which can be either `created`, `pending`, `running`,
        /// `succeeded`, `failed`, or `cancelled`.
        /// </param>
        /// <param name="hyperparameters">
        /// The hyperparameters used for the fine-tuning job. See the
        /// [fine-tuning guide](/docs/guides/fine-tuning) for more details.
        /// </param>
        /// <param name="trainingFile">
        /// The file ID used for training. You can retrieve the training data with the
        /// [Files API](/docs/api-reference/files/retrieve-contents).
        /// </param>
        /// <param name="validationFile">
        /// The file ID used for validation. You can retrieve the validation results with the
        /// [Files API](/docs/api-reference/files/retrieve-contents).
        /// </param>
        /// <param name="resultFiles">
        /// The compiled results file ID(s) for the fine-tuning job. You can retrieve the results with the
        /// [Files API](/docs/api-reference/files/retrieve-contents).
        /// </param>
        /// <param name="trainedTokens">
        /// The total number of billable tokens processed by this fine tuning job. The value will be null
        /// if the fine-tuning job is still running.
        /// </param>
        /// <param name="error">
        /// For fine-tuning jobs that have `failed`, this will contain more information on the cause of the
        /// failure.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="model"/>, <paramref name="organizationId"/>, <paramref name="hyperparameters"/>, <paramref name="trainingFile"/> or <paramref name="resultFiles"/> is null. </exception>
        internal FineTuningJob(string id, DateTimeOffset createdAt, DateTimeOffset? finishedAt, string model, string fineTunedModel, string organizationId, FineTuningJobStatus status, FineTuningJobHyperparameters hyperparameters, string trainingFile, string validationFile, IEnumerable<string> resultFiles, long? trainedTokens, FineTuningJobError error)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(model, nameof(model));
            Argument.AssertNotNull(organizationId, nameof(organizationId));
            Argument.AssertNotNull(hyperparameters, nameof(hyperparameters));
            Argument.AssertNotNull(trainingFile, nameof(trainingFile));
            Argument.AssertNotNull(resultFiles, nameof(resultFiles));

            Id = id;
            CreatedAt = createdAt;
            FinishedAt = finishedAt;
            Model = model;
            FineTunedModel = fineTunedModel;
            OrganizationId = organizationId;
            Status = status;
            Hyperparameters = hyperparameters;
            TrainingFile = trainingFile;
            ValidationFile = validationFile;
            ResultFiles = resultFiles.ToList();
            TrainedTokens = trainedTokens;
            Error = error;
        }

        /// <summary> Initializes a new instance of <see cref="FineTuningJob"/>. </summary>
        /// <param name="id"> The object identifier, which can be referenced in the API endpoints. </param>
        /// <param name="object"> The object type, which is always "fine_tuning.job". </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the fine-tuning job was created. </param>
        /// <param name="finishedAt">
        /// The Unix timestamp (in seconds) for when the fine-tuning job was finished. The value will be
        /// null if the fine-tuning job is still running.
        /// </param>
        /// <param name="model"> The base model that is being fine-tuned. </param>
        /// <param name="fineTunedModel">
        /// The name of the fine-tuned model that is being created. The value will be null if the
        /// fine-tuning job is still running.
        /// </param>
        /// <param name="organizationId"> The organization that owns the fine-tuning job. </param>
        /// <param name="status">
        /// The current status of the fine-tuning job, which can be either `created`, `pending`, `running`,
        /// `succeeded`, `failed`, or `cancelled`.
        /// </param>
        /// <param name="hyperparameters">
        /// The hyperparameters used for the fine-tuning job. See the
        /// [fine-tuning guide](/docs/guides/fine-tuning) for more details.
        /// </param>
        /// <param name="trainingFile">
        /// The file ID used for training. You can retrieve the training data with the
        /// [Files API](/docs/api-reference/files/retrieve-contents).
        /// </param>
        /// <param name="validationFile">
        /// The file ID used for validation. You can retrieve the validation results with the
        /// [Files API](/docs/api-reference/files/retrieve-contents).
        /// </param>
        /// <param name="resultFiles">
        /// The compiled results file ID(s) for the fine-tuning job. You can retrieve the results with the
        /// [Files API](/docs/api-reference/files/retrieve-contents).
        /// </param>
        /// <param name="trainedTokens">
        /// The total number of billable tokens processed by this fine tuning job. The value will be null
        /// if the fine-tuning job is still running.
        /// </param>
        /// <param name="error">
        /// For fine-tuning jobs that have `failed`, this will contain more information on the cause of the
        /// failure.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FineTuningJob(string id, FineTuningJobObject @object, DateTimeOffset createdAt, DateTimeOffset? finishedAt, string model, string fineTunedModel, string organizationId, FineTuningJobStatus status, FineTuningJobHyperparameters hyperparameters, string trainingFile, string validationFile, IReadOnlyList<string> resultFiles, long? trainedTokens, FineTuningJobError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            CreatedAt = createdAt;
            FinishedAt = finishedAt;
            Model = model;
            FineTunedModel = fineTunedModel;
            OrganizationId = organizationId;
            Status = status;
            Hyperparameters = hyperparameters;
            TrainingFile = trainingFile;
            ValidationFile = validationFile;
            ResultFiles = resultFiles;
            TrainedTokens = trainedTokens;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FineTuningJob"/> for deserialization. </summary>
        internal FineTuningJob()
        {
        }

        /// <summary> The object identifier, which can be referenced in the API endpoints. </summary>
        public string Id { get; }
        /// <summary> The object type, which is always "fine_tuning.job". </summary>
        public FineTuningJobObject Object { get; } = FineTuningJobObject.FineTuningJob;

        /// <summary> The Unix timestamp (in seconds) for when the fine-tuning job was created. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary>
        /// The Unix timestamp (in seconds) for when the fine-tuning job was finished. The value will be
        /// null if the fine-tuning job is still running.
        /// </summary>
        public DateTimeOffset? FinishedAt { get; }
        /// <summary> The base model that is being fine-tuned. </summary>
        public string Model { get; }
        /// <summary>
        /// The name of the fine-tuned model that is being created. The value will be null if the
        /// fine-tuning job is still running.
        /// </summary>
        public string FineTunedModel { get; }
        /// <summary> The organization that owns the fine-tuning job. </summary>
        public string OrganizationId { get; }
        /// <summary>
        /// The current status of the fine-tuning job, which can be either `created`, `pending`, `running`,
        /// `succeeded`, `failed`, or `cancelled`.
        /// </summary>
        public FineTuningJobStatus Status { get; }
        /// <summary>
        /// The hyperparameters used for the fine-tuning job. See the
        /// [fine-tuning guide](/docs/guides/fine-tuning) for more details.
        /// </summary>
        public FineTuningJobHyperparameters Hyperparameters { get; }
        /// <summary>
        /// The file ID used for training. You can retrieve the training data with the
        /// [Files API](/docs/api-reference/files/retrieve-contents).
        /// </summary>
        public string TrainingFile { get; }
        /// <summary>
        /// The file ID used for validation. You can retrieve the validation results with the
        /// [Files API](/docs/api-reference/files/retrieve-contents).
        /// </summary>
        public string ValidationFile { get; }
        /// <summary>
        /// The compiled results file ID(s) for the fine-tuning job. You can retrieve the results with the
        /// [Files API](/docs/api-reference/files/retrieve-contents).
        /// </summary>
        public IReadOnlyList<string> ResultFiles { get; }
        /// <summary>
        /// The total number of billable tokens processed by this fine tuning job. The value will be null
        /// if the fine-tuning job is still running.
        /// </summary>
        public long? TrainedTokens { get; }
        /// <summary>
        /// For fine-tuning jobs that have `failed`, this will contain more information on the cause of the
        /// failure.
        /// </summary>
        public FineTuningJobError Error { get; }
    }
}
