using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal6strdupEPKc")]
[DemangledName("__llvm_libc_20_1_2_::internal::strdup(char const*)")]
internal static partial class internal_strdup_char_const
{
	public unsafe static Struct_yx4nca Invoke(void* src)
	{
		cpp_optional_e5s7qx cpp_optional_e5s7qx2 = default(cpp_optional_e5s7qx);
		long num = 0L;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		void* dst = null;
		unchecked
		{
			if (src == null)
			{
				cpp_optional_char_optional_cpp_nullopt_t.Invoke(&cpp_optional_e5s7qx2);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num);
				num = unsigned_long_internal_string_length_char_char_const.Invoke(src) + 1L;
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				*(sbyte*)(&anon_izyfb8) = -86;
				AllocChecker_AllocChecker.Invoke(&anon_izyfb8);
				llvm_lifetime_start_p0.Invoke(8L, &dst);
				dst = operator_new_unsigned_long_AllocChecker_y8sjvz.Invoke(num, &anon_izyfb8);
				if (!AllocChecker_operator_bool_const.Invoke(&anon_izyfb8))
				{
					cpp_optional_char_optional_cpp_nullopt_t.Invoke(&cpp_optional_e5s7qx2);
				}
				else
				{
					inline_memcpy_void_void_const_unsigned_long.Invoke(dst, src, num);
					cpp_optional_char_optional_char.Invoke(&cpp_optional_e5s7qx2, &dst);
				}
				llvm_lifetime_end_p0.Invoke(8L, &dst);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
				llvm_lifetime_end_p0.Invoke(8L, &num);
			}
			return *(Struct_yx4nca*)(&cpp_optional_e5s7qx2.storage);
		}
	}
}
