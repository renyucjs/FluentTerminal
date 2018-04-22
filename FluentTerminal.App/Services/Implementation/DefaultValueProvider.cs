﻿using FluentTerminal.Models;
using FluentTerminal.Models.Enums;
using System;
using System.Collections.Generic;
using Windows.System;

namespace FluentTerminal.App.Services.Implementation
{
    internal class DefaultValueProvider : IDefaultValueProvider
    {
        public ApplicationSettings GetDefaultApplicationSettings()
        {
            return new ApplicationSettings
            {
                ConfirmClosingTabs = false,
                ConfirmClosingWindows = false,
                NewTerminalLocation = NewTerminalLocation.Tab
            };
        }

        public KeyBindings GetDefaultKeyBindings()
        {
            return new KeyBindings
            {
                NewTab = new[]
                {
                    new KeyBinding
                    {
                        Command = Command.NewTab,
                        Ctrl = true,
                        Alt = false,
                        Shift = false,
                        Key = (int)VirtualKey.T
                    }
                },
                CloseTab = new[] {
                    new KeyBinding
                    {
                        Command = Command.CloseTab,
                        Ctrl = true,
                        Alt = false,
                        Shift = false,
                        Key = (int)VirtualKey.W
                    }
                },
                NextTab = new[] {
                    new KeyBinding
                    {
                        Command = Command.NextTab,
                        Ctrl = true,
                        Alt = false,
                        Shift = false,
                        Key = (int)VirtualKey.Tab
                    }
                },
                PreviousTab = new[] {
                    new KeyBinding
                    {
                        Command = Command.PreviousTab,
                        Ctrl = true,
                        Alt = false,
                        Shift = true,
                        Key = (int)VirtualKey.Tab
                    }
                },
                NewWindow = new[] {
                    new KeyBinding
                    {
                        Command = Command.NewWindow,
                        Ctrl = true,
                        Alt = false,
                        Shift = false,
                        Key = (int)VirtualKey.N
                    }
                },
                ShowSettings = new[] {
                    new KeyBinding
                    {
                        Command = Command.ShowSettings,
                        Ctrl = true,
                        Alt = false,
                        Shift = false,
                        Key = 188 // comma
                    }
                },
                Copy = new[] {
                    new KeyBinding
                    {
                        Command = Command.Copy,
                        Ctrl = true,
                        Alt = false,
                        Shift = false,
                        Key = (int)VirtualKey.C
                    }
                },
                Paste = new[] {
                    new KeyBinding
                    {
                        Command = Command.Paste,
                        Ctrl = true,
                        Alt = false,
                        Shift = false,
                        Key = (int)VirtualKey.V
                    }
                },
                ToggleWindow = new[] {
                    new KeyBinding
                    {
                        Command = Command.ToggleWindow,
                        Ctrl = false,
                        Alt = false,
                        Shift = false,
                        Key = (int)VirtualKey.Scroll
                    }
                }
            };
        }

        public ShellConfiguration GetDefaultShellConfiguration()
        {
            return new ShellConfiguration
            {
                Shell = ShellType.PowerShell,
                CustomShellLocation = string.Empty,
                WorkingDirectory = string.Empty,
                Arguments = string.Empty
            };
        }

        public TerminalOptions GetDefaultTerminalOptions()
        {
            return new TerminalOptions
            {
                BellStyle = BellStyle.None,
                CursorBlink = true,
                CursorStyle = CursorStyle.Block,
                FontFamily = "Consolas",
                FontSize = 13
            };
        }

        public Guid GetDefaultThemeId()
        {
            return Guid.Parse("281e4352-bb50-47b7-a691-2b13830df95e");
        }

        public IEnumerable<TerminalTheme> GetPreInstalledThemes()
        {
            var defaultXterm = new TerminalTheme
            {
                Id = GetDefaultThemeId(),
                Author = "xterm.js",
                Name = "Xterm.js Default",
                PreInstalled = true,
                BackgroundOpacity = 0.8,
                Colors = new TerminalColors
                {
                    Black = "#2e3436",
                    Red = "#cc0000",
                    Green = "#4e9a06",
                    Yellow = "#c4a000",
                    Blue = "#3465a4",
                    Magenta = "#75507b",
                    Cyan = "#06989a",
                    White = "#d3d7cf",
                    BrightBlack = "#555753",
                    BrightRed = "#ef2929",
                    BrightGreen = "#8ae234",
                    BrightYellow = "#fce94f",
                    BrightBlue = "#729fcf",
                    BrightMagenta = "#ad7fa8",
                    BrightCyan = "#34e2e2",
                    BrightWhite = "#eeeeec",
                    Foreground = "#ffffff",
                    Background = "#000000",
                    Cursor = "#ffffff",
                    CursorAccent = "#000000",
                    Selection = "rgba(255, 255, 255, 0.3)"
                }
            };

            var powerShell = new TerminalTheme
            {
                Id = Guid.Parse("3571ce1b-31ce-4cf7-ae15-e0bff70c3eea"),
                Author = "Microsoft",
                Name = "PowerShell",
                PreInstalled = true,
                BackgroundOpacity = 0.8,
                Colors = new TerminalColors
                {
                    Black = "#000000",
                    Red = "#800000",
                    Green = "#008000",
                    Yellow = "#EEEDF0",
                    Blue = "#000080",
                    Magenta = "#012456",
                    Cyan = "#008080",
                    White = "#c0c0c0",
                    BrightBlack = "#808080",
                    BrightRed = "#ff0000",
                    BrightGreen = "#00ff00",
                    BrightYellow = "#ffff00",
                    BrightBlue = "#0000ff",
                    BrightMagenta = "#ff00ff",
                    BrightCyan = "#00ffff",
                    BrightWhite = "#ffffff",
                    Foreground = "#ffffff",
                    Background = "#012456",
                    Cursor = "#fedba9",
                    CursorAccent = "#000000",
                    Selection = "#fedba9"
                }
            };

            return new[] { defaultXterm, powerShell };
        }
    }
}