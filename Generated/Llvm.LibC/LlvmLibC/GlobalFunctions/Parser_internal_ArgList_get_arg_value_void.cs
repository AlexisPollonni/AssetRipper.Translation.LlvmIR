using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_get_arg_value_void
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEE13get_arg_valueIPvEET_m")]
	[DemangledName("void* __llvm_libc_20_1_2_::scanf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_arg_value<void*>(unsigned long)")]
	[return: NativeType("void*")]
	public unsafe static void* Invoke(scanf_core_Parser* @this, [NativeType("unsigned long")] long index)
	{
		if (index != 0L && index != @this->args_index)
		{
			Parser_internal_ArgList_args_to_index.Invoke(@this, index);
		}
		unchecked
		{
			@this->args_index++;
			return Parser_internal_ArgList_get_next_arg_value_void_qy27ek.Invoke(@this);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE13get_arg_valueIPvEENS_3cpp8optionalIT_EEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<void*> __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_arg_value<void*>(unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional<void*>")]
	public unsafe static Struct_yx4nca Invoke(printf_core_Parser* @this, [NativeType("unsigned long")] long index)
	{
		cpp_optional_77yu8f cpp_optional_77yu8f2 = default(cpp_optional_77yu8f);
		sbyte b = 0;
		printf_core_TypeDesc printf_core_TypeDesc2 = default(printf_core_TypeDesc);
		void* ptr = null;
		if (index != 0L && index != @this->args_index)
		{
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (Parser_internal_ArgList_args_to_index.Invoke(@this, index) ? ((sbyte)1) : ((sbyte)0));
			int num;
			if ((b & 1) != 1)
			{
				llvm_memset_p0_i64.Invoke(&cpp_optional_77yu8f2, 0, 16L, isVolatile: false);
				optional_void_Constructor.Invoke(&cpp_optional_77yu8f2);
				num = 1;
			}
			else
			{
				num = 0;
			}
			llvm_lifetime_end_p0.Invoke(1L, &b);
			switch (num)
			{
			case 0:
				break;
			case 1:
				goto IL_0122;
			default:
				throw new NotImplementedException("Reached LLVM unreachable instruction.");
			}
		}
		unchecked
		{
			*(short*)(&printf_core_TypeDesc2) = printf_core_type_desc_from_type_void_f5fqec.Invoke();
			Parser_internal_ArgList_set_type_desc.Invoke(@this, index, *(short*)(&printf_core_TypeDesc2));
			@this->args_index++;
			llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = Parser_internal_ArgList_get_next_arg_value_void_nyg6yu.Invoke(@this);
			optional_void_Constructor.Invoke(&cpp_optional_77yu8f2, &ptr);
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			goto IL_0122;
		}
		IL_0122:
		return *unchecked((Struct_yx4nca*)(&cpp_optional_77yu8f2.storage));
	}
}
