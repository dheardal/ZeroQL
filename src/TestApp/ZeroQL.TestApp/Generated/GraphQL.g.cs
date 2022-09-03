// This file generated for ZeroQL.
// <auto-generated/>
using System; 
using System.Linq; 
using System.Text.Json.Serialization; 

#nullable enable

namespace GraphQL.TestServer
{
    public class TestServerClient : global::ZeroQL.GraphQLClient<Query, Mutation>
    {
        public TestServerClient(global::System.Net.Http.HttpClient client, global::ZeroQL.IGraphQLQueryStrategy? queryStrategy = null) : base(client, queryStrategy)
        {
        }
    }

    [System.CodeDom.Compiler.GeneratedCode ( "ZeroQL" ,  "1.0.0.0" )]
    public class KeyValuePairOfStringAndString
    {
        public string Key { get; set; }

        public string Value { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode ( "ZeroQL" ,  "1.0.0.0" )]
    public class Mutation
    {
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("AddUser")]
        public User __AddUser { get; set; }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("AddUserProfileImage")]
        public int __AddUserProfileImage { get; set; }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("AddMyProfileImage")]
        public int __AddMyProfileImage { get; set; }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("AddUsersInfo")]
        public int __AddUsersInfo { get; set; }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("AddValues")]
        public int __AddValues { get; set; }

        [ZeroQL.GraphQLFieldSelector]
        public T AddUser<T>(string firstName, string lastName, Func<User, T> selector)
        {
            return selector(__AddUser);
        }

        [ZeroQL.GraphQLFieldSelector]
        public int AddUserProfileImage(int userId, global::ZeroQL.Upload file)
        {
            return __AddUserProfileImage;
        }

        [ZeroQL.GraphQLFieldSelector]
        public int AddMyProfileImage(global::ZeroQL.Upload file)
        {
            return __AddMyProfileImage;
        }

        [ZeroQL.GraphQLFieldSelector]
        public int AddUsersInfo(UserInfoInput[] users)
        {
            return __AddUsersInfo;
        }

        [ZeroQL.GraphQLFieldSelector]
        public int AddValues(string text, byte value1, byte? value2, short value3, short? value4, int value5, int? value6, long value7, long? value8, double value9, double? value10, double value11, double? value12, decimal value13, decimal? value14, DateTimeOffset value15, DateTimeOffset? value16, DateOnly value17, DateOnly? value18, Guid value19, Guid? value20, Guid[] value21, Guid[]? value22, Guid[] value23, Guid[]? value24, Guid[] value25, Guid[]? value26, KeyValuePairOfStringAndStringInput[] value27, KeyValuePairOfStringAndStringInput[]? value28, KeyValuePairOfStringAndStringInput value29, KeyValuePairOfStringAndStringInput? value30, DateTimeOffset value31, DateTimeOffset? value32)
        {
            return __AddValues;
        }
    }

    [System.CodeDom.Compiler.GeneratedCode ( "ZeroQL" ,  "1.0.0.0" )]
    public class Query
    {
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("Me")]
        public User __Me { get; set; }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("Users")]
        public User[] __Users { get; set; }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("UsersMatrix")]
        public User[][] __UsersMatrix { get; set; }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("UsersByKind")]
        public User[] __UsersByKind { get; set; }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("UsersIds")]
        public int[] __UsersIds { get; set; }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("User")]
        public User __User { get; set; }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("UsersByIds")]
        public User[] __UsersByIds { get; set; }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("UserKind")]
        public UserKind __UserKind { get; set; }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("Admin")]
        public User __Admin { get; set; }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("Container")]
        public TypesContainer __Container { get; set; }

        [ZeroQL.GraphQLFieldSelector]
        public T Me<T>(Func<User, T> selector)
        {
            return selector(__Me);
        }

        [ZeroQL.GraphQLFieldSelector]
        public T[] Users<T>(UserFilterInput filter, int page, int size, Func<User, T> selector)
        {
            return __Users.Select(o => selector(o)).ToArray();
        }

        public UserKind[] UserKinds { get; set; }

        [ZeroQL.GraphQLFieldSelector]
        public T[][] UsersMatrix<T>(Func<User, T> selector)
        {
            return __UsersMatrix.Select(o => o.Select(o => selector(o)).ToArray()).ToArray();
        }

        [ZeroQL.GraphQLFieldSelector]
        public T[] UsersByKind<T>(UserKind kind, int page, int size, Func<User, T> selector)
        {
            return __UsersByKind.Select(o => selector(o)).ToArray();
        }

        [ZeroQL.GraphQLFieldSelector]
        public int[] UsersIds(UserKind kind, int page, int size)
        {
            return __UsersIds;
        }

        [ZeroQL.GraphQLFieldSelector]
        public T? User<T>(int id, Func<User?, T> selector)
        {
            return __User != default ? selector(__User) : default;
        }

        [ZeroQL.GraphQLFieldSelector]
        public T[] UsersByIds<T>(int[] ids, Func<User, T> selector)
        {
            return __UsersByIds.Select(o => selector(o)).ToArray();
        }

        [ZeroQL.GraphQLFieldSelector]
        public UserKind UserKind(int id)
        {
            return __UserKind;
        }

        [ZeroQL.GraphQLFieldSelector]
        public T? Admin<T>(int id, Func<User?, T> selector)
        {
            return __Admin != default ? selector(__Admin) : default;
        }

        [ZeroQL.GraphQLFieldSelector]
        public T Container<T>(Func<TypesContainer, T> selector)
        {
            return selector(__Container);
        }
    }

    [System.CodeDom.Compiler.GeneratedCode ( "ZeroQL" ,  "1.0.0.0" )]
    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode ( "ZeroQL" ,  "1.0.0.0" )]
    public class TypesContainer
    {
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("Value27")]
        public KeyValuePairOfStringAndString[] __Value27 { get; set; }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("Value28")]
        public KeyValuePairOfStringAndString[] __Value28 { get; set; }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("Value29")]
        public KeyValuePairOfStringAndString __Value29 { get; set; }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("Value30")]
        public KeyValuePairOfStringAndString __Value30 { get; set; }

        public string Text { get; set; }

        public byte Value1 { get; set; }

        public byte? Value2 { get; set; }

        public short Value3 { get; set; }

        public short? Value4 { get; set; }

        public int Value5 { get; set; }

        public int? Value6 { get; set; }

        public long Value7 { get; set; }

        public long? Value8 { get; set; }

        public double Value9 { get; set; }

        public double? Value10 { get; set; }

        public double Value11 { get; set; }

        public double? Value12 { get; set; }

        public decimal Value13 { get; set; }

        public decimal? Value14 { get; set; }

        public DateTimeOffset Value15 { get; set; }

        public DateTimeOffset? Value16 { get; set; }

        public DateOnly Value17 { get; set; }

        public DateOnly? Value18 { get; set; }

        public Guid Value19 { get; set; }

        public Guid? Value20 { get; set; }

        public Guid[] Value21 { get; set; }

        public Guid[]? Value22 { get; set; }

        public Guid[] Value23 { get; set; }

        public Guid[]? Value24 { get; set; }

        public Guid[] Value25 { get; set; }

        public Guid[]? Value26 { get; set; }

        [ZeroQL.GraphQLFieldSelector]
        public T[] Value27<T>(Func<KeyValuePairOfStringAndString, T> selector)
        {
            return __Value27.Select(o => selector(o)).ToArray();
        }

        [ZeroQL.GraphQLFieldSelector]
        public T[]? Value28<T>(Func<KeyValuePairOfStringAndString, T> selector)
        {
            return __Value28?.Select(o => selector(o)).ToArray();
        }

        [ZeroQL.GraphQLFieldSelector]
        public T Value29<T>(Func<KeyValuePairOfStringAndString, T> selector)
        {
            return selector(__Value29);
        }

        [ZeroQL.GraphQLFieldSelector]
        public T? Value30<T>(Func<KeyValuePairOfStringAndString?, T> selector)
        {
            return __Value30 != default ? selector(__Value30) : default;
        }

        public DateTimeOffset Value31 { get; set; }

        public DateTimeOffset? Value32 { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode ( "ZeroQL" ,  "1.0.0.0" )]
    public class User
    {
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never), JsonPropertyName("Role")]
        public Role __Role { get; set; }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public UserKind UserKind { get; set; }

        [ZeroQL.GraphQLFieldSelector]
        public T? Role<T>(Func<Role?, T> selector)
        {
            return __Role != default ? selector(__Role) : default;
        }
    }

    [System.CodeDom.Compiler.GeneratedCode ( "ZeroQL" ,  "1.0.0.0" )]
    public class KeyValuePairOfStringAndStringInput
    {
        public string Key { get; set; }

        public string Value { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode ( "ZeroQL" ,  "1.0.0.0" )]
    public class PageInput
    {
        public int Count { get; set; }

        public int Size { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode ( "ZeroQL" ,  "1.0.0.0" )]
    public class UserFilterInput
    {
        public UserKind UserKind { get; set; }

        public PageInput? Page { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode ( "ZeroQL" ,  "1.0.0.0" )]
    public class UserInfoInput
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public global::ZeroQL.Upload Avatar { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode ( "ZeroQL" ,  "1.0.0.0" )]
    public enum UserKind
    {
        Good,
        Bad
    }
}