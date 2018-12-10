//================================================================================
//  Copyright (c) 2003 Lionel Laské
//
// This file is part of Proverbes.net.
//
// Proverbes.net is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// Proverbes.net is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with Proverbes.net; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//
//================================================================================

using System.Reflection;
using System.Runtime.CompilerServices;

//
// Les informations générales relatives à un assembly dépendent de 
// l'ensemble d'attributs suivant. Pour modifier les informations
// associées à un assembly, changez les valeurs de ces attributs.
//
[assembly: AssemblyTitle("Proverbes.net")]
[assembly: AssemblyDescription("Site proverbes de grand-mère")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Proverbes.net")]
[assembly: AssemblyCopyright("Lionel Laské 2003")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]		

//
// Les informations de version pour un assembly se composent des quatre valeurs suivantes :
//
//      Version principale
//      Version secondaire 
//      Numéro de build
//      Révision
//
// Vous pouvez spécifier toutes les valeurs ou indiquer des numéros de révision et de build par défaut 
// en utilisant '*', comme ci-dessous :

[assembly: AssemblyVersion("1.0.*")]

//
// Pour signer votre assembly, vous devez spécifier la clé à utiliser. Consultez 
// la documentation Microsoft .NET Framework pour plus d'informations sur la signature d'un assembly.
//
// Utilisez les attributs ci-dessous pour contrôler la clé utilisée lors de la signature. 
//
// Remarques : 
//   (*) Si aucune clé n'est spécifiée, l'assembly n'est pas signé.
//   (*) KeyName fait référence à une clé installée dans le fournisseur de
//       services cryptographiques (CSP) de votre ordinateur. KeyFile fait référence à un fichier qui contient
//       une clé.
//   (*) Si les valeurs de KeyFile et de KeyName sont spécifiées, le 
//       traitement suivant se produit :
//       (1) Si KeyName se trouve dans le CSP, la clé est utilisée.
//       (2) Si KeyName n'existe pas mais que KeyFile existe, la clé 
//           de KeyFile est installée dans le CSP et utilisée.
//   (*) Pour créer KeyFile, vous pouvez utiliser l'utilitaire sn.exe (Strong Name, Nom fort).
//        Lors de la spécification de KeyFile, son emplacement doit être
//        relatif au "répertoire de sortie du projet". L'emplacement du répertoire de sortie
//        du projet diffère selon que vous travaillez avec un projet local ou Web.
//        Pour les projets locaux, le répertoire de sortie du projet est défini comme
//       <Project Directory>\obj\<Configuration>. Par exemple, si votre KeyFile se trouve
//       dans le répertoire du projet, vous devez spécifier l'attribut AssemblyKeyFile 
//       sous la forme [assembly: AssemblyKeyFile("..\\..\\mykey.snk")]
//        Pour les projets Web, le répertoire de sortie du projet est défini comme 
//       %HOMEPATH%\VSWebCache\<Nom ordinateur>\<Project Directoryt>\obj\<Configuration>.
//   (*) DelaySign (signature différée) est une option avancée. Pour plus d'informations, consultez la
//       documentation Microsoft .NET Framework.
//
[assembly: AssemblyDelaySign(false)]
[assembly: AssemblyKeyFile("")]
[assembly: AssemblyKeyName("")]
