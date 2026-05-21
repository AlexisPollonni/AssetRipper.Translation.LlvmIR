using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_get_arg_value_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE13get_arg_valueIPcEENS_3cpp8optionalIT_EEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<char*> __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_arg_value<char*>(unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional<char*>")]
	public unsafe static Struct_yx4nca Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_Parser* This, [MangledName("index")][NativeType("unsigned long")] long Index)
	{
		Llvm_libc_20_1_2_cpp_optional_77yu8f llvm_libc_20_1_2_cpp_optional_77yu8f = default(Llvm_libc_20_1_2_cpp_optional_77yu8f);
		sbyte b = 0;
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		void* ptr = null;
		if (Index != 0L && Index != This->Args_index)
		{
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (Parser_internal_ArgList_args_to_index.Invoke(This, Index) ? ((sbyte)1) : ((sbyte)0));
			int num;
			if ((b & 1) != 1)
			{
				Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_optional_77yu8f, 0, 16L, isVolatile: false);
				Optional_char_Constructor_e46sab.Invoke(&llvm_libc_20_1_2_cpp_optional_77yu8f);
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
			*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc) = Printf_core_type_desc_from_type_char.Invoke();
			Parser_internal_ArgList_set_type_desc.Invoke(This, Index, *(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc));
			This->Args_index++;
			Llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = Parser_internal_ArgList_get_next_arg_value_char.Invoke(This);
			Optional_char_Constructor_rumc48.Invoke(&llvm_libc_20_1_2_cpp_optional_77yu8f, &ptr);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			goto IL_0122;
		}
		IL_0122:
		return *unchecked((Struct_yx4nca*)(&llvm_libc_20_1_2_cpp_optional_77yu8f.Storage));
	}
}
