using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_strdup
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal6strdupEPKc")]
	[DemangledName("__llvm_libc_20_1_2_::internal::strdup(char const*)")]
	public unsafe static Struct_yx4nca Invoke([MangledName("src")][NativeType("char const*")] void* Src)
	{
		Llvm_libc_20_1_2_cpp_optional_77yu8f llvm_libc_20_1_2_cpp_optional_77yu8f = default(Llvm_libc_20_1_2_cpp_optional_77yu8f);
		long num = 0L;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		void* dst = null;
		unchecked
		{
			if (Src == null)
			{
				Optional_char_Constructor_949f9e.Invoke(&llvm_libc_20_1_2_cpp_optional_77yu8f);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num);
				num = Internal_string_length_char.Invoke(Src) + 1L;
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
				*(sbyte*)(&anon_izyfb) = -86;
				AllocChecker_Constructor.Invoke(&anon_izyfb);
				Llvm_lifetime_start_p0.Invoke(8L, &dst);
				dst = NewArray.Invoke(num, &anon_izyfb);
				if (!AllocChecker_ToBoolean.Invoke(&anon_izyfb))
				{
					Optional_char_Constructor_949f9e.Invoke(&llvm_libc_20_1_2_cpp_optional_77yu8f);
				}
				else
				{
					Llvm_libc_20_1_2_inline_memcpy.Invoke(dst, Src, num);
					Optional_char_Constructor_rumc48.Invoke(&llvm_libc_20_1_2_cpp_optional_77yu8f, &dst);
				}
				Llvm_lifetime_end_p0.Invoke(8L, &dst);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
				Llvm_lifetime_end_p0.Invoke(8L, &num);
			}
			return *(Struct_yx4nca*)(&llvm_libc_20_1_2_cpp_optional_77yu8f.Storage);
		}
	}
}
