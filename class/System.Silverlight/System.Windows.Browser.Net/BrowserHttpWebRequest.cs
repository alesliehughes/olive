//
// System.Windows.Browser.Net.BrowserHttpWebRequest class
//
// Authors:
//	Jb Evain  <jbevain@novell.com>
//
// Copyright (C) 2007 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Globalization;
using System.IO;
using System.Net;

namespace System.Windows.Browser.Net
{
	public class BrowserHttpWebRequest : HttpWebRequest
	{
#if NET_2_1
		Uri uri;
		string method = "GET";
		WebHeaderCollection headers = new WebHeaderCollection ();

		public BrowserHttpWebRequest (Uri uri)
			: base (uri)
		{
			this.uri = uri;
		}

		[MonoTODO]
		~BrowserHttpWebRequest ()
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public override void Abort ()
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public override void AddRange (int range)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public override void AddRange (int @from, int to)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public override void AddRange (string rangeSpecifier, int range)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public override void AddRange (string rangeSpecifier, int @from, int to)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public override IAsyncResult BeginGetRequestStream (AsyncCallback callback, object state)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public override IAsyncResult BeginGetResponse (AsyncCallback callback, object state)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public override Stream EndGetRequestStream (IAsyncResult asyncResult)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public override HttpWebResponse EndGetResponse (IAsyncResult asyncResult)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public override Stream GetRequestStream ()
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public override HttpWebResponse GetResponse ()
		{
			throw new NotImplementedException ();
		}
		
		public override string Accept {
			get { return headers [HttpRequestHeader.Accept]; }
			set { headers [HttpRequestHeader.Connection] = value; }
		}

		public override Uri Address {
			get { return uri; }
		}

		public override bool AllowAutoRedirect {
			get { return true; } // silverlight always returns true
			set { throw new NotSupportedException (); }
		}

		public override bool AllowWriteStreamBuffering {
			get { return true; }
			set { throw new NotSupportedException (); }
		}

		public override DecompressionMethods AutomaticDecompression {
			get { return DecompressionMethods.None; }
			set { throw new NotSupportedException (); }
		}

		public override string Connection {
			get { return headers [HttpRequestHeader.Connection]; }
			set { headers [HttpRequestHeader.Connection] = value; }
		}

		public override long ContentLength {
			get {
					return long.Parse (headers [HttpRequestHeader.ContentLength], NumberStyles.Integer, CultureInfo.InvariantCulture);
			}
			set {
				headers [HttpRequestHeader.ContentLength] = value.ToString (CultureInfo.InvariantCulture);
			}
		}

		public override string ContentType {
			get { return headers [HttpRequestHeader.ContentType]; }
			set { headers [HttpRequestHeader.ContentType] = value; }
		}

		public Delegate ContinueDelegate {
			get { throw new NotSupportedException (); }
			set { throw new NotSupportedException (); }
		}

		public object CookieContainer {
			get { throw new NotSupportedException (); }
			set { throw new NotSupportedException (); }
		}

		public object Credentials {
			get { throw new NotSupportedException (); }
			set { throw new NotSupportedException (); }
		}

		public override string Expect {
			get { return headers [HttpRequestHeader.Expect]; }
			set { headers [HttpRequestHeader.Expect] = value; }
		}

		[MonoTODO]
		public override bool HaveResponse {
			get { throw new NotImplementedException (); }
		}

		public override WebHeaderCollection Headers {
			get { return headers; }
			set { headers = value; }
		}

		public override bool KeepAlive {
			get { throw new NotSupportedException (); }
			set { throw new NotSupportedException (); }
		}

		public override string MediaType {
			get { throw new NotSupportedException (); }
			set { throw new NotSupportedException (); }
		}

		public override string Method {
			get { return method; }
			set { method = value; }
		}

		public override bool Pipelined {
			get { throw new NotSupportedException (); }
			set { throw new NotSupportedException (); }
		}

		public override bool PreAuthenticate {
			get { throw new NotSupportedException (); }
			set { throw new NotSupportedException (); }
		}

		public override int ReadWriteTimeout {
			get { throw new NotSupportedException (); }
			set { throw new NotSupportedException (); }
		}

		public override string Referer {
			get { return headers [HttpRequestHeader.Referer]; }
			set { headers [HttpRequestHeader.Referer] = value; }
		}

		public override Uri RequestUri {
			get { return uri; }
		}

		public override bool SendChunked {
			get { throw new NotSupportedException (); }
			set { throw new NotSupportedException (); }
		}

		public override int Timeout {
			get { throw new NotSupportedException (); }
			set { throw new NotSupportedException (); }
		}

		public override string TransferEncoding {
			get { return headers [HttpRequestHeader.TransferEncoding]; }
			set { headers [HttpRequestHeader.TransferEncoding] = value; }
		}

		public override string UserAgent {
			get { return headers [HttpRequestHeader.UserAgent]; }
			set { headers [HttpRequestHeader.UserAgent] = value; }
		}
#else
		public BrowserHttpWebRequest (Uri uri)
			: base (null, default (System.Runtime.Serialization.StreamingContext))
		{
			throw new NotSupportedException ("BrowserHttpWebRequest can only be used in the context of a plugin");
		}

		~BrowserHttpWebRequest ()
		{
		}
#endif
	}
}
