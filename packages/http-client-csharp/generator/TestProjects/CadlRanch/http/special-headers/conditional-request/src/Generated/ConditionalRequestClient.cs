// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;

namespace SpecialHeaders.ConditionalRequest
{
    public partial class ConditionalRequestClient
    {
        public ConditionalRequestClient() : this(new Uri("http://localhost:3000"), new ConditionalRequestClientOptions()) => throw null;

        public ConditionalRequestClient(Uri endpoint, ConditionalRequestClientOptions options) => throw null;

        public ClientPipeline Pipeline => throw null;

        public virtual ClientResult PostIfMatch(string ifMatch, RequestOptions options) => throw null;

        public virtual Task<ClientResult> PostIfMatchAsync(string ifMatch, RequestOptions options) => throw null;

        public virtual ClientResult PostIfMatch(string ifMatch = null, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<ClientResult> PostIfMatchAsync(string ifMatch = null, CancellationToken cancellationToken = default) => throw null;

        public virtual ClientResult PostIfNoneMatch(string ifNoneMatch, RequestOptions options) => throw null;

        public virtual Task<ClientResult> PostIfNoneMatchAsync(string ifNoneMatch, RequestOptions options) => throw null;

        public virtual ClientResult PostIfNoneMatch(string ifNoneMatch = null, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<ClientResult> PostIfNoneMatchAsync(string ifNoneMatch = null, CancellationToken cancellationToken = default) => throw null;

        public virtual ClientResult HeadIfModifiedSince(DateTimeOffset? ifModifiedSince, RequestOptions options) => throw null;

        public virtual Task<ClientResult> HeadIfModifiedSinceAsync(DateTimeOffset? ifModifiedSince, RequestOptions options) => throw null;

        public virtual ClientResult HeadIfModifiedSince(DateTimeOffset? ifModifiedSince = null, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<ClientResult> HeadIfModifiedSinceAsync(DateTimeOffset? ifModifiedSince = null, CancellationToken cancellationToken = default) => throw null;

        public virtual ClientResult PostIfUnmodifiedSince(DateTimeOffset? ifUnmodifiedSince, RequestOptions options) => throw null;

        public virtual Task<ClientResult> PostIfUnmodifiedSinceAsync(DateTimeOffset? ifUnmodifiedSince, RequestOptions options) => throw null;

        public virtual ClientResult PostIfUnmodifiedSince(DateTimeOffset? ifUnmodifiedSince = null, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<ClientResult> PostIfUnmodifiedSinceAsync(DateTimeOffset? ifUnmodifiedSince = null, CancellationToken cancellationToken = default) => throw null;
    }
}
