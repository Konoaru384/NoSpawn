# 🚫 NoSpawn

<table align="center">
  <tr>
    <td>
      <img src="https://img.shields.io/github/downloads/Konoaru384/NoSpawn/total?label=Total%20Downloads&color=blue&style=for-the-badge" alt="Total Downloads" />
    </td>
    <td>
      <img src="https://img.shields.io/badge/EXILED-9.6+%2B-blueviolet?style=for-the-badge" alt="EXILED 9.6" />
    </td>
    <td>
      <a href="https://discord.gg/vxGeGFr5Bc">
        <img src="https://img.shields.io/badge/Discord-Join%20Us-7289DA?style=for-the-badge&logo=discord" alt="Discord Server" />
      </a>
    </td>
  </tr>
</table>

---

## 🧃 Description

NoSpawn is an EXILED plugin for **SCP: Secret Laboratory** that blocks Chaos Insurgency and MTF respawns for a configurable duration.  

You can set a delay in hours, minutes, and seconds before these teams are allowed to respawn.

---

## 🚀 Features

- Prevents Chaos and MTF respawns until the configured delay elapses.  
- Delay adjustable via three parameters: hours, minutes, and seconds.  
- Hot-enable or disable the plugin without restarting the server.  
- Debug mode to output detailed logs in the console.

---

## ⚙️ Configuration

Locate the config file at **Plugins/NoSpawn/config.yml**. It exposes:

```yaml
NoSpawn:
  # Enable or disable the plugin
  IsEnabled: true

  # Enable debug logging
  Debug: false

  # Respawn delay (hours / minutes / seconds)
  DelayHours:   0
  DelayMinutes: 40
  DelaySeconds: 0
