# DisruptiveSoftware.Cryptography.Tools

A collection of cryptographic tools to facilitate the generation/manipulation of SSL certificates. It uses the [Bouncy Castle Crypto](https://bouncycastle.org/csharp/index.html) library.

## Tools
* __SSLCertBundleGenerator__ - can be used to generate a certificate bundle: a Certificate Authority (CA) certificate and an SSL certificate that can be installed on a web server (e.g. IIS, Apache);
* __CertUtil__ - can be used to export cryptographic objects (Private Key, Public Key Certificate) from [PKCS #12](https://en.wikipedia.org/wiki/PKCS_12) file format to a DER (binary) or to a PEM (Base64 ASCII) file format.

## Repository

The main repository is hosted on [GitHub](https://github.com/cristianst85/DisruptiveSoftware.Cryptography.Tools).

## Changelog

See [CHANGELOG](https://github.com/cristianst85/DisruptiveSoftware.Cryptography.Tools/blob/master/CHANGELOG.md) file for details.

## Development

* Any edition of [Visual Studio 2019](https://visualstudio.microsoft.com/vs/), C# 7.0 language features.

## License

* The source code in this repository is released under the GNU GPLv2 or later license. See the [bundled LICENSE](https://github.com/cristianst85/DisruptiveSoftware.Cryptography.Tools/blob/master/LICENSE) file for details.
* Includes third party libraries like [BouncyCastle.Crypto](https://www.bouncycastle.org/csharp/) that are subject to their respective license agreements.
* Menu icons are from the Silk icon set by [Mark James](http://www.famfamfam.com/lab/icons/silk/) licensed under [Creative Commons Attribution 2.5](http://creativecommons.org/licenses/by/2.5/).
* Applications icons are from the Farm-Fresh icon set by [Fatcow Web Hosting](https://www.fatcow.com/free-icons) licensed under [Creative Commons Attribution 3.0](https://creativecommons.org/licenses/by/3.0/).

## Related Projects
 
* [DisruptiveSoftware.Cryptography](https://github.com/cristianst85/DisruptiveSoftware.Cryptography)
