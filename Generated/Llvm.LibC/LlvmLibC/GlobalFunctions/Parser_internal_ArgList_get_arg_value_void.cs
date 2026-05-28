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
	public unsafe static void* Invoke([MangledName("this")] Scanf_core_Parser* This, [MangledName("index")][NativeType("unsigned long")] long Index)
	{
		if (Index != 0L && Index != This->Args_index)
		{
			Parser_internal_ArgList_args_to_index.Invoke(This, Index);
		}
		unchecked
		{
			This->Args_index++;
			return Parser_internal_ArgList_get_next_arg_value_void_qy27ek.Invoke(This);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE13get_arg_valueIPvEENS_3cpp8optionalIT_EEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<void*> __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_arg_value<void*>(unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional<void*>")]
	public unsafe static Struct_yx4nca Invoke([MangledName("this")] Printf_core_Parser* This, [MangledName("index")][NativeType("unsigned long")] long Index)
	{
		Cpp_optional_77yu8f cpp_optional_77yu8f = default(Cpp_optional_77yu8f);
		sbyte b = 0;
		Printf_core_TypeDesc printf_core_TypeDesc = default(Printf_core_TypeDesc);
		void* ptr = null;
		if (Index != 0L && Index != This->Args_index)
		{
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (Parser_internal_ArgList_args_to_index.Invoke(This, Index) ? ((sbyte)1) : ((sbyte)0));
			int num;
			if ((b & 1) != 1)
			{
				Llvm_memset_p0_i64.Invoke(&cpp_optional_77yu8f, 0, 16L, isVolatile: false);
				Optional_void_Constructor.Invoke(&cpp_optional_77yu8f);
				num = 1;
			}
			else
			{
				num = 0;
			}
			Llvm_lifetime_end_p0.Invoke(1L, &b);
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
			*(short*)(&printf_core_TypeDesc) = Printf_core_type_desc_from_type_void_f5fqec.Invoke();
			Parser_internal_ArgList_set_type_desc.Invoke(This, Index, *(short*)(&printf_core_TypeDesc));
			This->Args_index++;
			Llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = Parser_internal_ArgList_get_next_arg_value_void_nyg6yu.Invoke(This);
			Optional_void_Constructor.Invoke(&cpp_optional_77yu8f, &ptr);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			goto IL_0122;
		}
		IL_0122:
		return *unchecked((Struct_yx4nca*)(&cpp_optional_77yu8f.Storage));
	}
}
