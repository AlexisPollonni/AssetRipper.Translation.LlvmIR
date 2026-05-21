using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_get_arg_value_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE13get_arg_valueIlEENS_3cpp8optionalIT_EEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long> __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_arg_value<long>(unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional<long>")]
	public unsafe static Struct_8myw6y Invoke(printf_core_Parser* @this, [NativeType("unsigned long")] long index)
	{
		cpp_optional_d6hvji cpp_optional_d6hvji2 = default(cpp_optional_d6hvji);
		sbyte b = 0;
		printf_core_TypeDesc printf_core_TypeDesc2 = default(printf_core_TypeDesc);
		long num = 0L;
		if (index != 0L && index != @this->args_index)
		{
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (Parser_internal_ArgList_args_to_index.Invoke(@this, index) ? ((sbyte)1) : ((sbyte)0));
			int num2;
			if ((b & 1) != 1)
			{
				llvm_memset_p0_i64.Invoke(&cpp_optional_d6hvji2, 0, 16L, isVolatile: false);
				optional_long_Constructor.Invoke(&cpp_optional_d6hvji2);
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
				goto IL_0122;
			default:
				throw new NotImplementedException("Reached LLVM unreachable instruction.");
			}
		}
		unchecked
		{
			*(short*)(&printf_core_TypeDesc2) = printf_core_type_desc_from_type_long.Invoke();
			Parser_internal_ArgList_set_type_desc.Invoke(@this, index, *(short*)(&printf_core_TypeDesc2));
			@this->args_index++;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = Parser_internal_ArgList_get_next_arg_value_long.Invoke(@this);
			optional_long_Constructor.Invoke(&cpp_optional_d6hvji2, &num);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			goto IL_0122;
		}
		IL_0122:
		return *unchecked((Struct_8myw6y*)(&cpp_optional_d6hvji2.storage));
	}
}
