﻿namespace Taikandi.Telebot.Types
{
    using System.ComponentModel.DataAnnotations;

    using Newtonsoft.Json;

    /// <summary>
    /// This object represents an audio file (voice note).
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Audio
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the duration of the audio in seconds as defined by sender.
        /// </summary>
        [JsonProperty("duration", Required = Required.Always)]
        public int Duration { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for this file.
        /// </summary>
        [Required]
        [JsonProperty("file_id", Required = Required.Always)]
        public string FileId { get; set; }

        /// <summary>Gets or sets the file size (Optional).</summary>
        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        /// <summary>
        /// Gets or sets the MIME type of the file as defined by sender (Optional).
        /// </summary>
        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or sets the performer of the audio as defined by sender or by audio tags (Optional).
        /// </summary>
        [JsonProperty("performer")]
        public string Performer { get; set; }

        /// <summary>
        /// Gets or sets the title of the audio as defined by sender or by audio tags (Optional).
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        #endregion
    }
}