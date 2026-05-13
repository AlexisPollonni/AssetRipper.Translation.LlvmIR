using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE13get_arg_valueIiEENS_3cpp8optionalIT_EEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<int> __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_arg_value<int>(unsigned long)")]
internal static partial class cpp_optional_int_printf_core_Parser_internal_ArgList_get_arg_value_int_unsigned_long
{
	public unsafe static long Invoke(printf_core_Parser* @this, long index)
	{
		cpp_optional_39hkks cpp_optional_39hkks2 = default(cpp_optional_39hkks);
		sbyte b = 0;
		printf_core_TypeDesc printf_core_TypeDesc2 = default(printf_core_TypeDesc);
		int num = 0;
		if (index != 0L && index != @this->args_index)
		{
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (printf_core_Parser_internal_ArgList_args_to_index_unsigned_long.Invoke(@this, index) ? ((sbyte)1) : ((sbyte)0));
			int num2;
			if ((b & 1) != 1)
			{
				llvm_memset_p0_i64.Invoke(&cpp_optional_39hkks2, 0, 8L, isVolatile: false);
				cpp_optional_int_optional.Invoke(&cpp_optional_39hkks2);
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
				goto IL_011b;
			default:
				throw new NotImplementedException("Reached LLVM unreachable instruction.");
			}
		}
		unchecked
		{
			*(short*)(&printf_core_TypeDesc2) = printf_core_TypeDesc_printf_core_type_desc_from_type_int.Invoke();
			printf_core_Parser_internal_ArgList_set_type_desc_unsigned_long_printf_core_TypeDesc.Invoke(@this, index, *(short*)(&printf_core_TypeDesc2));
			@this->args_index++;
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = int_printf_core_Parser_internal_ArgList_get_next_arg_value_int.Invoke(@this);
			cpp_optional_int_optional_int.Invoke(&cpp_optional_39hkks2, &num);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			goto IL_011b;
		}
		IL_011b:
		return *unchecked((long*)(&cpp_optional_39hkks2.storage));
	}
}
