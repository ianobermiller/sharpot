﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using System.IO;
using System.CodeDom.Compiler;
using System.Reflection;

namespace SharpOT.Scripting
{
    public class Scripting
    {
        // TODO: .NET 3.5 setting
        private static CSharpCodeProvider cSharpCodeProvider = new CSharpCodeProvider();
        private static VBCodeProvider vBCodeProvider = new VBCodeProvider();
        private static List<IScript> loadedScripts = new List<IScript>();

        public static void LoadAllScripts(Game game)
        {
            foreach (string directory in SharpOT.Properties.Settings.Default.ScriptsDirectory.Split(';'))
            {
                if (!Directory.Exists(directory)) continue;
                foreach (string path in Directory.GetFiles(directory))
                {
                    if (!File.Exists(path)) continue;
                    LoadScript(game, path);
                }
            }
        }

        public static void LoadScript(Game game, string path)
        {
            Assembly assembly = null;
            switch (Path.GetExtension(path))
            {
                case ".dll":
                    assembly = LoadDll(path);
                    break;
                case ".cs":
                    assembly = CompileScript(path, cSharpCodeProvider);
                    break;
                case ".vb":
                    assembly = CompileScript(path, vBCodeProvider);
                    break;
            }

            if (assembly != null)
            {
                foreach (IScript script in FindScripts(assembly))
                {
                    loadedScripts.Add(script);
                    script.Start(game);
                }
            }
        }

        public static Assembly CompileScript(string path, CodeDomProvider provider)
        {
            CompilerParameters compilerParameters = new CompilerParameters();
            compilerParameters.GenerateExecutable = false;
            compilerParameters.GenerateInMemory = true;
            compilerParameters.IncludeDebugInformation = false;
            compilerParameters.ReferencedAssemblies.Add("System.dll");
            compilerParameters.ReferencedAssemblies.Add(System.Reflection.Assembly.GetExecutingAssembly().Location);
            CompilerResults results = provider.CompileAssemblyFromFile(compilerParameters, path);
            if (results.Errors.Count == 0)
            {
                return results.CompiledAssembly;
            }
            return null;
        }

        public static IEnumerable<IScript> FindScripts(Assembly assembly)
        {
            foreach (Type t in assembly.GetTypes())
            {
                if (t.GetInterface("IScript", true) != null)
                {
                    yield return (IScript)assembly.CreateInstance(t.FullName);
                }
            }
        }

        public static Assembly LoadDll(string path)
        {
            return Assembly.LoadFile(path);
        }
    }
}