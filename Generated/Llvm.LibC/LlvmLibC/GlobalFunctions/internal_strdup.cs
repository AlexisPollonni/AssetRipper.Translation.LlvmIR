using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_strdup
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal6strdupEPKc")]
	[DemangledName("__llvm_libc_20_1_2_::internal::strdup(char const*)")]
	public unsafe static Struct_yx4nca Invoke([NativeType("char const*")] void* src)
	{
		cpp_optional_77yu8f cpp_optional_77yu8f2 = default(cpp_optional_77yu8f);
		long num = 0L;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		void* dst = null;
		unchecked
		{
			if (src == null)
			{
				optional_char_Constructor_949f9e.Invoke(&cpp_optional_77yu8f2);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num);
				num = internal_string_length_char.Invoke(src) + 1L;
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				*(sbyte*)(&anon_izyfb8) = -86;
				AllocChecker_Constructor.Invoke(&anon_izyfb8);
				llvm_lifetime_start_p0.Invoke(8L, &dst);
				dst = NewArray.Invoke(num, &anon_izyfb8);
				if (!AllocChecker_ToBoolean.Invoke(&anon_izyfb8))
				{
					optional_char_Constructor_949f9e.Invoke(&cpp_optional_77yu8f2);
				}
				else
				{
					inline_memcpy.Invoke(dst, src, num);
					optional_char_Constructor_rumc48.Invoke(&cpp_optional_77yu8f2, &dst);
				}
				llvm_lifetime_end_p0.Invoke(8L, &dst);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
				llvm_lifetime_end_p0.Invoke(8L, &num);
			}
			return *(Struct_yx4nca*)(&cpp_optional_77yu8f2.storage);
		}
	}
}
