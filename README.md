<h1 align="center">
  Visual Labelling UI </br>
  <img src="https://github.com/zulfikar4568/PCI.VisualLabellingUI/actions/workflows/dotnet.yml/badge.svg" />
  <a href="https://github.com/zulfikar4568/PCI.VisualLabellingUI/releases/latest"><img src="https://img.shields.io/github/release/zulfikar4568/PCI.VisualLabellingUI.svg" /></a>
  <a href="https://github.com/zulfikar4568/PCI.VisualLabellingUI/blob/master/LICENSE"><img src="https://img.shields.io/github/license/zulfikar4568/PCI.VisualLabellingUI.svg" /></a>
</h1>

<p align="center">
  <a href="" target="blank"><img src="https://user-images.githubusercontent.com/64786139/216618716-0b8b7c78-c514-49bb-91b3-a6934262b45e.png" alt="App" /></a>
  <br>
  <i>Store the Image from the camera integration into Opcenter Siemens.</i>
  <br>
</p>

# Change the Config of the Application
Edit the hosts in your `Endpoints.config`
```config
<endpoint address="https://<your server host>/CamstarWCFServices/DirectAccessService.svc"
```

And Edit the Configuration Application in `App.config`

# Enabled Event Log on windows Machine
- Log on to the computer as an administrator.
- Click Start, click Run, type Regedit in the Open box, and then click OK. - The Registry Editor window appears.
- Locate the following registry subkey
```
Computer\HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\EventLog
```
- Right-click Eventlog, and then click Permissions. The Permissions for Eventlog dialog box appears.
  
<p align="center">
  <a href="" target="blank"><img src="./Images/EventLogPermission1.jpg" alt="Permission Event Log" /></a>
</p>

- Click Add, add the user account or group that you want and set the following permissions: `Full Control`.

<p align="center">
  <a href="" target="blank"><img src="./Images/EventLogPermission2.jpg" alt="Permission Event Log" /></a>
</p>

- Locate the following registry subkey
```
Computer\HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\EventLog\Security
```
<p align="center">
  <a href="" target="blank"><img src="./Images/EventLogPermission3.jpg" alt="Permission Event Log" /></a>
</p>

- Click Add, add the user account or group that you want and set the following permissions: `Full Control`.

<p align="center">
  <a href="" target="blank"><img src="./Images/EventLogPermission4.jpg" alt="Permission Event Log" /></a>
</p>

# License & Copy Right
© M. Zulfikar Isnaen, This is Under [MIT License](LICENSE).
