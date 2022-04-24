# PAM-WindowsHello
<h2>
  ⚠️ You probably do NOT want to use this for anything security-critical ⚠️ <br/>
  I am not responsible for anyone bypassing the login on a system you install this to!
</h2>

This utility allows to authenticate in WSL using Windows Hello

## Installation

1. Download `WindowsHelloAuthenticator.exe` from the Releases page or the Actions tab
2. Save the file to `/usr/local/bin/WindowsHelloAuthenticator.exe` in your WSL distro.
3. Ensure that the file is owned by `root:root` and has `0755` permissions
4. Copy `pam_config` from this repo to `/usr/share/pam-configs/windows-hello`
5. Run `sudo pam-auth-update --package --enable windows-hello`

If your distro does not have `pam-auth-update`, you'll need to update the files in `/etc/pam.d/` manually
