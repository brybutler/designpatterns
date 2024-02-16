﻿using System.ComponentModel.DataAnnotations;
using GangOf4Patterns.Behavioural.ChainOfResponsiblity.Models;

namespace GangOf4Patterns.Behavioural.ChainOfResponsiblity.Handlers;

public class DocumentTitleHandler : IHandler<Document>
{
    private IHandler<Document>? _successor;

    public void Handle(Document document)
    {
        if (document.Title == string.Empty)
            throw new ValidationException();

        _successor?.Handle(document);
    }

    public IHandler<Document> SetSuccessor(IHandler<Document> successor)
    {
        _successor = successor;
        return successor;
    }

}