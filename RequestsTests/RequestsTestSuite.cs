using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RequestsTests
{
    [TestClass]
    public class RequestsTestSuite
    {
        [TestMethod]
        public void TestInvalidUrl()
        {
            //self.assertRaises(ValueError, requests.get, 'hiwpefhipowhefopw')
        }

        [TestMethod]
        public void TestGet()
        {
            //def Test_HTTP_200_OK_GET(self):
            //r = requests.get('http://google.com')
            //self.assertEqual(r.status_code, 200)
        }

        [TestMethod]
        public void TestSecureGet()
        {
            //def Test_HTTPS_200_OK_GET(self):
            //r = requests.get('https://google.com')
            //self.assertEqual(r.status_code, 200)
        }

        [TestMethod]
        public void TestGetWithParams()
        {
            //def Test_HTTP_200_OK_GET_WITH_PARAMS(self):
            //heads = {'User-agent': 'Mozilla/5.0'}
            //r = requests.get('http://www.google.com/search', params={'q': 'test'}, headers=heads)
            //self.assertEqual(r.status_code, 200)
        }

        [TestMethod]
        public void TestGetWithMixedParams()
        {
            //def Test_HTTP_200_OK_GET_WITH_MIXED_PARAMS(self):
            //heads = {'User-agent': 'Mozilla/5.0'}
            //r = requests.get('http://google.com/search?test=true', params={'q': 'test'}, headers=heads)
            //self.assertEqual(r.status_code, 200)
        }

        [TestMethod]
        public void TestUserAgentTransfers()
        {
            //def Test_user_agent_transfers(self):
            //"""Issue XX"""
            //heads = {
            //    'User-agent':
            //        'Mozilla/5.0 (github.com/kennethreitz/requests)'
            //}
            //r = requests.get('http://whatsmyua.com', headers=heads);
            //self.assertTrue(heads['User-agent'] in r.content)

            //heads = {
            //    'user-agent':
            //        'Mozilla/5.0 (github.com/kennethreitz/requests)'
            //}

            //r = requests.get('http://whatsmyua.com', headers=heads);
            //self.assertTrue(heads['user-agent'] in r.content)
        }

        [TestMethod]
        public void TestHead()
        {
            //def Test_HTTP_200_OK_HEAD(self):
            //    r = requests.head('http://google.com')
            //    self.assertEqual(r.status_code, 200)
        }

        [TestMethod]
        public void TestSecureHead()
        {
            //def Test_HTTPS_200_OK_HEAD(self):
            //    r = requests.head('https://google.com')
            //    self.assertEqual(r.status_code, 200)
        }

        [TestMethod]
        public void TestAuthSecureGet()
        {
            //def Test_AUTH_HTTPS_200_OK_GET(self):
            //    auth = ('requeststest', 'requeststest')
            //    url = 'https://convore.com/api/account/verify.json'
            //    r = requests.get(url, auth=auth)

            //    self.assertEqual(r.status_code, 200)

            //    r = requests.get(url)
            //    self.assertEqual(r.status_code, 200)

            //    # reset auto authentication
            //    requests.auth_manager.empty()
        }

        [TestMethod]
        public void TestPostFiles()
        {
            //def Test_POSTBIN_GET_POST_FILES(self):
            //    bin = requests.post('http://www.postbin.org/')
            //    self.assertEqual(bin.status_code, 302)

            //    post_url = bin.headers['location']
            //    post = requests.post(post_url, data={'some': 'data'})
            //    self.assertEqual(post.status_code, 201)

            //    post2 = requests.post(post_url, files={'some': open('Test_requests.py')})
            //    self.assertEqual(post2.status_code, 201)

            //    post3 = requests.post(post_url, data='[{"some": "json"}]')
            //    self.assertEqua2l(post.status_code, 201)
        }

        [TestMethod]
        public void TestPostFilesWithParams()
        {
            //def Test_POSTBIN_GET_POST_FILES_WITH_PARAMS(self):
            //    bin = requests.post('http://www.postbin.org/')
            //    self.assertEqual(bin.status_code, 302)

            //    post_url = bin.headers['location']

            //    post2 = requests.post(post_url, files={'some': open('Test_requests.py')}, data={'some': 'data'})
            //    self.assertEqual(post2.status_code, 201)
        }

        [TestMethod]
        public void TestPostFilesWithHeaders()
        {
            //def Test_POSTBIN_GET_POST_FILES_WITH_HEADERS(self):
            //    bin = requests.post('http://www.postbin.org/')
            //    self.assertEqual(bin.status_code, 302)

            //    post_url = bin.headers['location']

            //    post2 = requests.post(post_url, files={'some': open('Test_requests.py')},
            //    headers = {'User-Agent': 'requests-tests'})

            //    self.assertEqual(post2.status_code, 201)
        }

        [TestMethod]
        public void TestNonZeroEvaluation()
        {
            //def Test_nonzero_evaluation(self):
            //    r = requests.get('http://google.com/some-404-url')
            //    self.assertEqual(bool(r), False)

            //    r = requests.get('http://google.com/')
            //    self.assertEqual(bool(r), True)
        }

        [TestMethod]
        public void TestRequestOkSet()
        {
            //def Test_request_ok_set(self):
            //    r = requests.get('http://google.com/some-404-url')
            //    self.assertEqual(r.ok, False)
        }

        [TestMethod]
        public void TestStatusRaising()
        {
            //def Test_status_raising(self):
            //    r = requests.get('http://google.com/some-404-url')
            //    self.assertRaises(requests.HTTPError, r.raise_for_status)

            //    r = requests.get('http://google.com/')
            //    self.assertFalse(r.error)
            //    r.raise_for_status()
        }

        [TestMethod]
        public void TestCookieJar()
        {
            //def Test_cookie_jar(self):
            //    """
            //    .. todo:: This really doesn't test to make sure the cookie is working
            //    """

            //    jar = cookielib.CookieJar()
            //    self.assertFalse(jar)

            //    requests.get('http://google.com', cookies=jar)
            //    self.assertTrue(jar)
        }

        [TestMethod]
        public void TestDecompressGzip()
        {
            //def Test_decompress_gzip(self):

            //    r = requests.get('http://api.stackoverflow.com/1.1/users/495995/top-answer-tags')
            //    r.content.decode('ascii')
        }

        [TestMethod]
        public void TestAutoAuth()
        {
            //def Test_autoauth(self):

            //    conv_auth = ('requeststest', 'requeststest')
            //    requests.auth_manager.add_auth('convore.com', conv_auth)

            //    r = requests.get('https://convore.com/api/account/verify.json')
            //    self.assertEquals(r.status_code, 200)
        }

        [TestMethod]
        public void TestUnicodeGet()
        {
            //def Test_unicode_get(self):

            //    requests.get('http://google.com', params={'foo': u'føø'})
            //    requests.get('http://google.com', params={u'føø': u'føø'})
            //    requests.get('http://google.com', params={'føø': 'føø'})
            //    requests.get('http://google.com', params={'foo': u'foo'})
            //    requests.get('http://google.com/ø', params={'foo': u'foo'})
        }

        [TestMethod]
        public void TestAuthRecursion()
        {
            //def Test_httpauth_recursion(self):
            //    conv_auth = ('requeststest', 'bad_password')

            //    r = requests.get('https://convore.com/api/account/verify.json', auth=conv_auth)
            //    self.assertEquals(r.status_code, 401)
        }

        [TestMethod]
        public void TestSettings()
        {
            //def Test_settings(self):
            //    with requests.settings(timeout=0.0001):
            //        self.assertRaises(requests.Timeout, requests.get, 'http://google.com')

            //    with requests.settings(timeout=10):
            //        requests.get('http://google.com')
        }

        [TestMethod]
        public void TestNonUrlEncodedPostWithData()
        {
            //def Test_nonurlencoded_post_data(self):
            //    requests.post('http://google.com', data='foo')

        }
    }
}