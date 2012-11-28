// Type: System.Data.Entity.Database
// Assembly: EntityFramework, Version=4.4.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: F:\Project\Indexr\packages\EntityFramework.5.0.0\lib\net40\EntityFramework.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Infrastructure;

namespace System.Data.Entity
{
  /// <summary>
  /// An instances of this class is obtained from an <see cref="T:System.Data.Entity.DbContext"/> object and can be used
  ///                 to manage the actual database backing a DbContext or connection.
  ///                 This includes creating, deleting, and checking for the existence of a database.
  ///                 Note that deletion and checking for existence of a database can be performed using just a
  ///                 connection (i.e. without a full context) by using the static methods of this class.
  /// 
  /// </summary>
  public class Database
  {
    /// <summary>
    /// Gets or sets the database initialization strategy.  The database initialization strategy is called when <see cref="T:System.Data.Entity.DbContext"/> instance
    ///                 is initialized from a <see cref="T:System.Data.Entity.Infrastructure.DbCompiledModel"/>.  The strategy can optionally check for database existence, create a new database, and
    ///                 seed the database with data.
    ///                 The default strategy is an instance of <see cref="T:System.Data.Entity.CreateDatabaseIfNotExists`1"/>.
    /// 
    /// </summary>
    /// <typeparam name="TContext">The type of the context.</typeparam><param name="strategy">The strategy.</param>
    /// <value>
    /// The database creation strategy.
    /// </value>
    public static void SetInitializer<TContext>(IDatabaseInitializer<TContext> strategy) where TContext : DbContext;
    /// <summary>
    /// Runs the the registered <see cref="T:System.Data.Entity.IDatabaseInitializer`1"/> on this context.
    /// 
    ///                 If "force" is set to true, then the initializer is run regardless of whether or not it
    ///                 has been run before.  This can be useful if a database is deleted while an app is running
    ///                 and needs to be reinitialized.
    /// 
    ///                 If "force" is set to false, then the initializer is only run if it has not already been
    ///                 run for this context, model, and connection in this app domain. This method is typically
    ///                 used when it is necessary to ensure that the database has been created and seeded
    ///                 before starting some operation where doing so lazily will cause issues, such as when the
    ///                 operation is part of a transaction.
    /// 
    /// </summary>
    /// <param name="force">if set to <c>true</c> the initializer is run even if it has already been run.</param>
    public void Initialize(bool force);
    /// <summary>
    /// Checks whether or not the database is compatible with the the current Code First model.
    /// 
    /// </summary>
    /// 
    /// <remarks>
    /// Model compatibility currently uses the following rules.
    /// 
    ///             If the context was created using either the Model First or Database First approach then the
    ///             model is assumed to be compatible with the database and this method returns true.
    /// 
    ///             For Code First the model is considered compatible if the model is stored in the database
    ///             in the Migrations history table and that model has no differences from the current model as
    ///             determined by Migrations model differ.
    /// 
    ///             If the model is not stored in the database but an EF 4.1/4.2 model hash is found instead,
    ///             then this is used to check for compatibility.
    /// 
    /// </remarks>
    /// <param name="throwIfNoMetadata">If set to <c>true</c> then an exception will be thrown if no model metadata is found in
    ///             the database. If set to <c>false</c> then this method will return <c>true</c> if metadata
    ///             is not found.</param>
    /// <returns>
    /// True if the model hash in the context and the database match; false otherwise.
    /// 
    /// </returns>
    public bool CompatibleWithModel(bool throwIfNoMetadata);
    /// <summary>
    /// Creates a new database on the database server for the model defined in the backing context.
    ///                 Note that calling this method before the database initialization strategy has run will disable
    ///                 executing that strategy.
    /// 
    /// </summary>
    public void Create();
    /// <summary>
    /// Creates a new database on the database server for the model defined in the backing context, but only
    ///                 if a database with the same name does not already exist on the server.
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// True if the database did not exist and was created; false otherwise.
    /// </returns>
    public bool CreateIfNotExists();
    /// <summary>
    /// Checks whether or not the database exists on the server.
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// True if the database exists; false otherwise.
    /// </returns>
    public bool Exists();
    /// <summary>
    /// Deletes the database on the database server if it exists, otherwise does nothing.
    ///                 Calling this method from outside of an initializer will mark the database as having
    ///                 not been initialized. This means that if an attempt is made to use the database again
    ///                 after it has been deleted, then any initializer set will run again and, usually, will
    ///                 try to create the database again automatically.
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// True if the database did exist and was deleted; false otherwise.
    /// </returns>
    public bool Delete();
    /// <summary>
    /// Checks whether or not the database exists on the server.
    ///                 The connection to the database is created using the given database name or connection string
    ///                 in the same way as is described in the documentation for the <see cref="T:System.Data.Entity.DbContext"/> class.
    /// 
    /// </summary>
    /// <param name="nameOrConnectionString">The database name or a connection string to the database.</param>
    /// <returns>
    /// True if the database exists; false otherwise.
    /// </returns>
    public static bool Exists(string nameOrConnectionString);
    /// <summary>
    /// Deletes the database on the database server if it exists, otherwise does nothing.
    ///                 The connection to the database is created using the given database name or connection string
    ///                 in the same way as is described in the documentation for the <see cref="T:System.Data.Entity.DbContext"/> class.
    /// 
    /// </summary>
    /// <param name="nameOrConnectionString">The database name or a connection string to the database.</param>
    /// <returns>
    /// True if the database did exist and was deleted; false otherwise.
    /// </returns>
    public static bool Delete(string nameOrConnectionString);
    /// <summary>
    /// Checks whether or not the database exists on the server.
    /// 
    /// </summary>
    /// <param name="existingConnection">An existing connection to the database.</param>
    /// <returns>
    /// True if the database exists; false otherwise.
    /// </returns>
    public static bool Exists(DbConnection existingConnection);
    /// <summary>
    /// Deletes the database on the database server if it exists, otherwise does nothing.
    /// 
    /// </summary>
    /// <param name="existingConnection">An existing connection to the database.</param>
    /// <returns>
    /// True if the database did exist and was deleted; false otherwise.
    /// </returns>
    public static bool Delete(DbConnection existingConnection);
    /// <summary>
    /// Creates a raw SQL query that will return elements of the given generic type.
    ///                 The type can be any type that has properties that match the names of the columns returned
    ///                 from the query, or can be a simple primitive type.  The type does not have to be an
    ///                 entity type. The results of this query are never tracked by the context even if the
    ///                 type of object returned is an entity type.  Use the <see cref="M:System.Data.Entity.DbSet`1.SqlQuery(System.String,System.Object[])"/>
    ///                 method to return entities that are tracked by the context.
    /// 
    /// </summary>
    /// <typeparam name="TElement">The type of object returned by the query.</typeparam><param name="sql">The SQL query string.</param><param name="parameters">The parameters to apply to the SQL query string.</param>
    /// <returns>
    /// A <see cref="T:System.Collections.Generic.IEnumerable`1"/> object that will execute the query when it is enumerated.
    /// </returns>
    public IEnumerable<TElement> SqlQuery<TElement>(string sql, params object[] parameters);
    /// <summary>
    /// Creates a raw SQL query that will return elements of the given type.
    ///                 The type can be any type that has properties that match the names of the columns returned
    ///                 from the query, or can be a simple primitive type.  The type does not have to be an
    ///                 entity type. The results of this query are never tracked by the context even if the
    ///                 type of object returned is an entity type.  Use the <see cref="M:System.Data.Entity.DbSet.SqlQuery(System.String,System.Object[])"/>
    ///                 method to return entities that are tracked by the context.
    /// 
    /// </summary>
    /// <param name="elementType">The type of object returned by the query.</param><param name="sql">The SQL query string.</param><param name="parameters">The parameters to apply to the SQL query string.</param>
    /// <returns>
    /// A <see cref="T:System.Collections.IEnumerable"/> object that will execute the query when it is enumerated.
    /// </returns>
    public IEnumerable SqlQuery(Type elementType, string sql, params object[] parameters);
    /// <summary>
    /// Executes the given DDL/DML command against the database.
    /// 
    /// </summary>
    /// <param name="sql">The command string.</param><param name="parameters">The parameters to apply to the command string.</param>
    /// <returns>
    /// The result returned by the database after executing the command.
    /// </returns>
    public int ExecuteSqlCommand(string sql, params object[] parameters);
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ToString();
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj);
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode();
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new Type GetType();
    /// <summary>
    /// Returns the connection being used by this context.  This may cause the
    ///                 connection to be created if it does not already exist.
    /// 
    /// </summary>
    /// <exception cref="T:System.InvalidOperationException">Thrown if the context has been disposed.</exception>
    public DbConnection Connection { get; }
    /// <summary>
    /// The connection factory to use when creating a <see cref="T:System.Data.Common.DbConnection"/> from just
    ///                 a database name or a connection string.
    /// 
    /// </summary>
    /// 
    /// <remarks>
    /// This is used when just a database name or connection string is given to <see cref="T:System.Data.Entity.DbContext"/> or when
    ///                 the no database name or connection is given to DbContext in which case the name of
    ///                 the context class is passed to this factory in order to generate a DbConnection.
    ///                 By default, the <see cref="T:System.Data.Entity.Infrastructure.IDbConnectionFactory"/> instance to use is read from the applications .config
    ///                 file from the "EntityFramework DefaultConnectionFactory" entry in appSettings. If no entry is found in
    ///                 the config file then <see cref="T:System.Data.Entity.Infrastructure.SqlConnectionFactory"/> is used. Setting this property in code
    ///                 always overrides whatever value is found in the config file.
    /// 
    /// </remarks>
    public static IDbConnectionFactory DefaultConnectionFactory { get; set; }
  }
}
