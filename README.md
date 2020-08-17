# starter-web-api

[![License: MIT](https://img.shields.io/badge/LICENSE-MIT-informational.svg)](https://opensource.org/licenses/MIT)

**starter-web-api** is a Web API starter project for [DNN Platform](https://github.com/dnnsoftware/Dnn.Platform) (formerly known as DotNetNuke) made by and for the [DNN Community](https://dnncommunity.org).

## Installation

### Installation Option #1

Clone this repo into a clean directory of your choice.

```bash
git clone https://github.com/DNNCommunity/starter-web-api.git .
```

### Installation Option #2

Use **dnn-cli**, which is [available as an npm package](https://www.npmjs.com/package/@dnncommunity/dnn-cli).  **dnn-cli** it can be installed via **yarn** or **npm**.

---
#### Install dnn-cli...

...via **yarn**:

```bash
yarn global add @dnncommunity/dnn-cli
```

...via **npm**:

```bash
npm install -g @dnncommunity/dnn-cli
```
---

Once **dnn-cli** is installed, this starter project can be installed into an empty directory of your choice.

```bash
cd <directory path>
dnn web-api
```

## Usage

1. Install DNN in a `.\Website` folder (root of directory in which this project is cloned)
2. Open solution file in Visual Studio 2019 (Run as Adminstrator...)
3. Build in `Debug` or `Release` mode

### Debug

By default this will compile the project and deploy it to the `.\Website` folder.  
- DLL and PDB files will be deployed to `.\Website\bin`
- All other relevant files will be deployed to `.\Website\DesktopModules\WebApi\starter-web-api`

### Release

By default this will create a Web API install package and place in `.\Website\Install\Library` so it will be in **Available Extensions** within DNN (SETTINGS > Extensions > Available Extensions).

### Implementation

This stand-alone Web API is configured with three endpoints.

#### DnnHello (GET)

```
http://yourdomain.com/API/starter-web-api/Home/DnnHello

RESPONSE
"Hello from Dnn!"
```

This endpoint uses the `[DnnAuthorize()]` DNN Web API attribute for authorization.  This means the endpoint must be called within 
the DNN instance by an authenticated user.  That said, this endpoint can be tested in a browser tab if you are already logged in 
with an active DNN session on the instance the extension is installed.

#### DnnHelloPersonalize (POST)

```
http://yourdomain.com/API/starter-web-api/Home/DnnHelloPersonalize

POST DATA
name: string

RESPONSE
"Hello <name> from Dnn!"
```

This endpoint also uses the `[DnnAuthorize()]` DNN Web API attribute for authorization.
In addition, it uses the `[ValidateAntiForgeryToken()]` attribute since this is a POST 
action and we need to protect against Cross Site request Forgery (CSRF) attacks.  

#### Additional Notes Regarding Authorization
There are other attributes available for various levels of authorization within the DNN Services Framework (e.g., AllowAnonymous, 
DnnModuleAuthorize).  There are also options within some of these attributes to limit access to specific security roles (e.g., "Registered Users")
or specific authentication types (e.g., "JWT").  Please see [DNN Docs](https://dnndocs.com) for more information.

## Contributing
Pull requests are welcome. Please open an issue first to document the bug or enhancement details.

## License
[![License: MIT](https://img.shields.io/badge/LICENSE-MIT-informational.svg)](https://opensource.org/licenses/MIT)