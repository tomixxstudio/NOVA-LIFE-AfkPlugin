# NOVA-LIFE-AfkPlugin
💤 Nova-Life AFK+ Plugin

Un plugin avancé pour gérer l’AFK dans Nova-Life, avec protection complète du joueur.

✨ Fonctionnalités

Commande /afk

Active le mode AFK.

Désactive la perte de nourriture et de soif.

Téléporte automatiquement le joueur sous la map dans une zone sécurisée.

Affiche un message dans le chat indiquant que le joueur est AFK.

Commande /unafk

Désactive le mode AFK.

Restaure la consommation normale de faim/soif.

Ramène le joueur à sa position initiale (ou une autre position définie).

Annonce le retour du joueur dans le chat.

🛡️ Objectifs du plugin

Empêcher les trolls, agressions ou interactions non RP pendant l’AFK.

Éviter les morts absurdes dues à la faim/soif.

Garantir une absence sécurisée et propre pour les joueurs.

📦 Installation

Télécharger le fichier du plugin.

Glisser le dossier dans :

NovaLife/Plugins/


Redémarrer le serveur.

⚙️ Configuration (optionnelle)

Selon ta version, tu peux configurer :

La position sécurisée sous la map

Les messages affichés dans le chat

Le système de retour à la position initiale

Exemple de config :

{
  "SafePosition": {
    "x": 0.0,
    "y": -200.0,
    "z": 0.0
  },
  "EnableReturnPosition": true,
  "AFKPrefix": "[AFK]"
}

🧩 Commands
Commande	Description
/afk	Active le mode AFK et protège le joueur.
/unafk	Désactive le mode AFK et restaure l’état normal.
🛠️ Développeur

Auteur : Tom

Plateforme : Nova-Life – Plugin C#

Compatibilité : Toutes versions supportant les commandes custom.

💬 Support

Pour toute demande, suggestion ou bug, crée un ticket ou ouvre une issue sur le repo.
