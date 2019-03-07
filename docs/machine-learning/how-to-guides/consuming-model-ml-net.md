---
title: Operationalize a trained machine learning model in apps - ML.NET
description: Discover how to use ML.NET to consume a trained and evaluated machine learning model in applications
ms.date: 03/05/2019
ms.custom: mvc,how-to
#Customer intent: As a developer, I want to use ML.NET to consume my trained and evaluated machine learning model in my applications.
---
# Operationalize a trained machine learning model in apps - ML.NET

> [!NOTE]
> This topic refers to ML.NET, which is currently in Preview, and material may be subject to change. For more information, visit [the ML.NET introduction](https://www.microsoft.com/net/learn/apps/machine-learning-and-ai/ml-dotnet).

This how-to and related sample are currently using **ML.NET version 0.10**. For more information, see the release notes at the [dotnet/machinelearning github repo](https://github.com/dotnet/machinelearning/tree/master/docs/release-notes)

When the model metrics look good to you, it's time to 'operationalize' the model. The `model` object you built can be consumed, persisted, and reused in different environments, applying the same steps that it 'learned' during training.

To save the model to a file, and reload it (potentially in a different context), use the following example:

```csharp
using (var stream = File.Create(modelPath))
{
    // Saving and loading happens to 'dynamic' models.
    mlContext.Model.Save(model, stream);
}

// Potentially, the lines below can be in a different process altogether.

// When you load the model, it's a transformer.
ITransformer loadedModel;
using (var stream = File.OpenRead(modelPath))
    loadedModel = mlContext.Model.Load(stream);
```
