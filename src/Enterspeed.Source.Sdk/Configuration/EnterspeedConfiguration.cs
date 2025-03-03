﻿namespace Enterspeed.Source.Sdk.Configuration
{
    public class EnterspeedConfiguration
    {
        /// <summary>
        /// Gets or sets the API key. Eg. source-xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the base URL.
        /// </summary>
        public string BaseUrl { get; set; }

        /// <summary>
        /// Gets or sets timeout in seconds. Default: 60 seconds.
        /// </summary>
        public int ConnectionTimeout { get; set; } = 60;

        /// <summary>
        /// Gets the current version for the Ingest Endpoint.
        /// </summary>
        public string IngestVersion => "1";
    }
}
