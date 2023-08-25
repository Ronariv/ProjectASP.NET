CREATE TABLE [dbo].[ItemType] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [ItemTypeName] VARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[User] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [UserName]     VARCHAR (50) NOT NULL,
    [UserEmail]    VARCHAR (50) NOT NULL,
    [UserPassword] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Item] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [ItemName]        VARCHAR (MAX) NOT NULL,
    [ItemPrice]       INT           NOT NULL,
    [ItemPicture]     VARCHAR (MAX) NOT NULL,
    [ItemDescription] VARCHAR (MAX) NOT NULL,
    [ItemTypeID]      INT           NOT NULL,
    [UserID]          INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([ItemTypeID]) REFERENCES [dbo].[ItemType] ([Id]),
    CONSTRAINT [FK_User] FOREIGN KEY ([UserID]) REFERENCES [dbo].[User] ([Id])
);

CREATE TABLE [dbo].[Cart] (
    [UserID]   INT NOT NULL,
    [ItemID]   INT NOT NULL,
    [Quantity] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC, [ItemID] ASC),
    FOREIGN KEY ([UserID]) REFERENCES [dbo].[User] ([Id]),
    FOREIGN KEY ([ItemID]) REFERENCES [dbo].[Item] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
);


CREATE TABLE [dbo].[TrHeader] (
    [Id]              INT  IDENTITY (1, 1) NOT NULL,
    [UserId]          INT  NOT NULL,
    [TransactionDate] DATE NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);

CREATE TABLE [dbo].[TrDetail] (
    [TrHeaderId] INT NOT NULL,
    [ItemID]     INT NOT NULL,
    [Quantity]   INT NOT NULL,
    PRIMARY KEY CLUSTERED ([TrHeaderId] ASC, [ItemID] ASC),
    FOREIGN KEY ([ItemID]) REFERENCES [dbo].[Item] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY ([TrHeaderId]) REFERENCES [dbo].[TrHeader] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
);

