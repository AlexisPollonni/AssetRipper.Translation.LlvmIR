using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_get_arg_value_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE13get_arg_valueIeEENS_3cpp8optionalIT_EEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long double> __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_arg_value<long double>(unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional<long double>")]
	public unsafe static void Invoke([MangledName("agg.result")] Cpp_optional_59q3zq* Agg_result, [MangledName("this")] Printf_core_Parser* This, [MangledName("index")] long Index)
	{
		sbyte b = 0;
		Printf_core_TypeDesc printf_core_TypeDesc = default(Printf_core_TypeDesc);
		double num = 0.0;
		if (Index != 0L && Index != This->Args_index)
		{
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (Parser_internal_ArgList_args_to_index.Invoke(This, Index) ? ((sbyte)1) : ((sbyte)0));
			int num2;
			if ((b & 1) != 1)
			{
				Llvm_memset_p0_i64.Invoke(Agg_result, 0, 32L, isVolatile: false);
				Optional_long_double_Constructor.Invoke(Agg_result);
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
				return;
			default:
				throw new NotImplementedException("Reached LLVM unreachable instruction.");
			}
		}
		unchecked
		{
			*(short*)(&printf_core_TypeDesc) = Printf_core_type_desc_from_type_long_double.Invoke();
			Parser_internal_ArgList_set_type_desc.Invoke(This, Index, *(short*)(&printf_core_TypeDesc));
			This->Args_index++;
			Llvm_lifetime_start_p0.Invoke(16L, &num);
			num = Parser_internal_ArgList_get_next_arg_value_long_double.Invoke(This);
			Optional_long_double_Constructor.Invoke(Agg_result, &num);
			Llvm_lifetime_end_p0.Invoke(16L, &num);
		}
	}
}
