﻿namespace OpenSilver.Samples.Showcase

open System
open System.Collections.Generic
open System.IO
open System.Linq
open System.Windows
open System.Windows.Controls
open System.Windows.Controls.Primitives
open System.Windows.Data
open System.Windows.Input
open System.Windows.Media
open System.Windows.Navigation

type Triggers_Demo() as this =
    inherit Triggers_DemoXaml()

    do
        this.InitializeComponent()
