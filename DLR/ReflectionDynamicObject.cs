using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;

namespace DLR
{
    public class ReflectionDynamicObject : DynamicObject
    {
        private const BindingFlags InstanceDefaultBindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

        private readonly object _originalObject;
        private readonly IDictionary<string, FieldInfo> _fields = new Dictionary<string, FieldInfo>();
        private readonly Type _type;
        
        public ReflectionDynamicObject(object obj)
        {
            _type = obj.GetType();
            _originalObject = obj ?? throw new ArgumentNullException(nameof(obj));
            CreateMemberCache();
        }

        private void CreateMemberCache()
        {

            foreach (var fieldInfo in _type.GetFields(InstanceDefaultBindingFlags))
                _fields.Add(fieldInfo.Name, fieldInfo);
        }
        
        public override bool TryGetMember(GetMemberBinder binder, out object? result)
        {
            string name = binder.Name;

            if (_fields.TryGetValue(name, out var field))
            {
                result = field.GetValue(_originalObject);
                return true;
            }

            result = null;
            return false;
        }

        

        // A complete version of this code is available on GitHub:
        // https://github.com/meziantou/Meziantou.Framework/blob/master/src/Meziantou.Framework/ReflectionDynamicObject.cs
    }
}