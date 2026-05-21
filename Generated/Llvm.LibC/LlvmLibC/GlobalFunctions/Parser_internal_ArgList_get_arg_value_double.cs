using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_get_arg_value_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE13get_arg_valueIdEENS_3cpp8optionalIT_EEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double> __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_arg_value<double>(unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional<double>")]
	public unsafe static Struct_8myw6y Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_Parser* This, [MangledName("index")][NativeType("unsigned long")] long Index)
	{
		Llvm_libc_20_1_2_cpp_optional_vhbvq7 llvm_libc_20_1_2_cpp_optional_vhbvq = default(Llvm_libc_20_1_2_cpp_optional_vhbvq7);
		sbyte b = 0;
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		double num = 0.0;
		if (Index != 0L && Index != This->Args_index)
		{
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (Parser_internal_ArgList_args_to_index.Invoke(This, Index) ? ((sbyte)1) : ((sbyte)0));
			int num2;
			if ((b & 1) != 1)
			{
				Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_optional_vhbvq, 0, 16L, isVolatile: false);
				Optional_double_Constructor_ye5f4u.Invoke(&llvm_libc_20_1_2_cpp_optional_vhbvq);
				num2 = 1;
			}
			else
			{
				num2 = 0;
			}
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			switch (num2)
			{
			case 0:
				break;
			case 1:
				goto IL_0129;
			default:
				throw new NotImplementedException("Reached LLVM unreachable instruction.");
			}
		}
		unchecked
		{
			*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc) = Printf_core_type_desc_from_type_double.Invoke();
			Parser_internal_ArgList_set_type_desc.Invoke(This, Index, *(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc));
			This->Args_index++;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = Parser_internal_ArgList_get_next_arg_value_double.Invoke(This);
			Optional_double_Constructor_3qcik5.Invoke(&llvm_libc_20_1_2_cpp_optional_vhbvq, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			goto IL_0129;
		}
		IL_0129:
		return *unchecked((Struct_8myw6y*)(&llvm_libc_20_1_2_cpp_optional_vhbvq.Storage));
	}
}
