# Verbose Extractor

**Extracteur de données “verbose” de VRAD/Hammer**  
Outil en C# (.NET WinForms) pour analyser et structurer les messages générés par VRAD ou Hammer (Source SDK 2013), avec focus sur Garry’s Mod.

---

##  Contexte

Lorsque VRAD ou Hammer génère de la sortie en mode “verbose” (via `$light -verbose`), Les infos se trouvent toujours à la fin. Cet outil vise à :
- Lire les logs “verbose” depuis un fichier.
- Structurer et filtrer les informations que l'on souhaite.
- Faciliter l’analyse pour les mappeurs ou développeurs d’outils.

---

##  Fonctionnalités

- Lecture log de la sortie standard de compilation VRAD/Hammer.
- Parsing des lignes.
- Interface simple (WinForms) pour afficher toutes les infos et les filtrer.
- Export des données (log, texte brute, tout types)
- Plateforme cible : .NET Framework (C#), Windows.

---

##  Installation & Utilisation

1. Clone le projet :
   ```bash
   git clone https://github.com/Lumino-2-0/Verbose_Extractor.git
   cd Verbose_Extractor

OU

[Télécharger la dernière version release à jour actuelle](https://github.com/Lumino-2-0/Verbose_Extractor/releases/download/V1/Verbose_Extractor.exe)
