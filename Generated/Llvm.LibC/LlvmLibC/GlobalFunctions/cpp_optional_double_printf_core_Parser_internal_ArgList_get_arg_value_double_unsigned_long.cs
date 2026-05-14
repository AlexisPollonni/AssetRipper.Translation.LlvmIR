using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE13get_arg_valueIdEENS_3cpp8optionalIT_EEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double> __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_arg_value<double>(unsigned long)")]
internal static partial class cpp_optional_double_printf_core_Parser_internal_ArgList_get_arg_value_double_unsigned_long
{
	public unsafe static Struct_8myw6y Invoke(printf_core_Parser* @this, long index)
	{
		cpp_optional_vhbvq7 cpp_optional_vhbvq8 = default(cpp_optional_vhbvq7);
		sbyte b = 0;
		printf_core_TypeDesc printf_core_TypeDesc2 = default(printf_core_TypeDesc);
		double num = 0.0;
		if (index != 0L && index != @this->args_index)
		{
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (printf_core_Parser_internal_ArgList_args_to_index_unsigned_long.Invoke(@this, index) ? ((sbyte)1) : ((sbyte)0));
			int num2;
			if ((b & 1) != 1)
			{
				llvm_memset_p0_i64.Invoke(&cpp_optional_vhbvq8, 0, 16L, isVolatile: false);
				cpp_optional_double_optional.Invoke(&cpp_optional_vhbvq8);
				num2 = 1;
			}
			else
			{
				num2 = 0;
			}
			llvm_lifetime_end_p0.Invoke(1L, &b);
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
			*(short*)(&printf_core_TypeDesc2) = printf_core_TypeDesc_printf_core_type_desc_from_type_double.Invoke();
			printf_core_Parser_internal_ArgList_set_type_desc_unsigned_long_printf_core_TypeDesc.Invoke(@this, index, *(short*)(&printf_core_TypeDesc2));
			@this->args_index++;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = double_printf_core_Parser_internal_ArgList_get_next_arg_value_double.Invoke(@this);
			cpp_optional_double_optional_double.Invoke(&cpp_optional_vhbvq8, &num);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			goto IL_0129;
		}
		IL_0129:
		return *unchecked((Struct_8myw6y*)(&cpp_optional_vhbvq8.storage));
	}
}
