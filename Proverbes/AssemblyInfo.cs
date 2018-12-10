//================================================================================
//  Copyright (c) 2003 Lionel Lask�
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
// Les informations g�n�rales relatives � un assembly d�pendent de 
// l'ensemble d'attributs suivant. Pour modifier les informations
// associ�es � un assembly, changez les valeurs de ces attributs.
//
[assembly: AssemblyTitle("Proverbes.net")]
[assembly: AssemblyDescription("Site proverbes de grand-m�re")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Proverbes.net")]
[assembly: AssemblyCopyright("Lionel Lask� 2003")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]		

//
// Les informations de version pour un assembly se composent des quatre valeurs suivantes�:
//
//      Version principale
//      Version secondaire 
//      Num�ro de build
//      R�vision
//
// Vous pouvez sp�cifier toutes les valeurs ou indiquer des num�ros de r�vision et de build par d�faut 
// en utilisant '*', comme ci-dessous :

[assembly: AssemblyVersion("1.0.*")]

//
// Pour signer votre assembly, vous devez sp�cifier la cl� � utiliser. Consultez 
// la documentation Microsoft .NET Framework pour plus d'informations sur la signature d'un assembly.
//
// Utilisez les attributs ci-dessous pour contr�ler la cl� utilis�e lors de la signature. 
//
// Remarques�: 
//   (*) Si aucune cl� n'est sp�cifi�e, l'assembly n'est pas sign�.
//   (*) KeyName fait r�f�rence � une cl� install�e dans le fournisseur de
//       services cryptographiques (CSP) de votre ordinateur. KeyFile fait r�f�rence � un fichier qui contient
//       une cl�.
//   (*) Si les valeurs de KeyFile et de KeyName sont sp�cifi�es, le 
//       traitement suivant se produit�:
//       (1) Si KeyName se trouve dans le CSP, la cl� est utilis�e.
//       (2) Si KeyName n'existe pas mais que KeyFile existe, la cl� 
//           de KeyFile est install�e dans le CSP et utilis�e.
//   (*) Pour cr�er KeyFile, vous pouvez utiliser l'utilitaire sn.exe (Strong Name, Nom fort).
//        Lors de la sp�cification de KeyFile, son emplacement doit �tre
//        relatif au "r�pertoire de sortie du projet". L'emplacement du r�pertoire de sortie
//        du projet diff�re selon que vous travaillez avec un projet local ou Web.
//        Pour les projets locaux, le r�pertoire de sortie du projet est d�fini comme
//       <Project Directory>\obj\<Configuration>. Par exemple, si votre KeyFile se trouve
//       dans le r�pertoire du projet, vous devez sp�cifier l'attribut AssemblyKeyFile 
//       sous la forme [assembly: AssemblyKeyFile("..\\..\\mykey.snk")]
//        Pour les projets Web, le r�pertoire de sortie du projet est d�fini comme 
//       %HOMEPATH%\VSWebCache\<Nom ordinateur>\<Project Directoryt>\obj\<Configuration>.
//   (*) DelaySign (signature diff�r�e) est une option avanc�e. Pour plus d'informations, consultez la
//       documentation Microsoft .NET Framework.
//
[assembly: AssemblyDelaySign(false)]
[assembly: AssemblyKeyFile("")]
[assembly: AssemblyKeyName("")]
