using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class inline_memmem_strcasestr_impl_char_const_char_const_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L13inline_memmemIRZNS_19__strcasestr_impl__EPKcS2_E3$_0EEPvPKvmS7_mOT_")]
	[DemangledName("void* __llvm_libc_20_1_2_::inline_memmem<__llvm_libc_20_1_2_::__strcasestr_impl__(char const*, char const*)::$_0&>(void const*, unsigned long, void const*, unsigned long, __llvm_libc_20_1_2_::__strcasestr_impl__(char const*, char const*)::$_0&)")]
	[return: NativeType("void*")]
	public unsafe static void* Invoke([NativeType("void const*")] void* haystack, [NativeType("unsigned long")] long haystack_len, [NativeType("void const*")] void* needle, [NativeType("unsigned long")] long needle_len, [NativeType("__llvm_libc_20_1_2_::__strcasestr_impl__(char const*, char const*)::$_0&")] void* comp)
	{
		void* result = null;
		void* ptr = null;
		void* ptr2 = null;
		long num = 0L;
		long num2 = 0L;
		unchecked
		{
			if (needle_len == 0L)
			{
				result = haystack;
			}
			else if ((ulong)needle_len > (ulong)haystack_len)
			{
				result = null;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &ptr);
				ptr = haystack;
				llvm_lifetime_start_p0.Invoke(8L, &ptr2);
				ptr2 = needle;
				llvm_lifetime_start_p0.Invoke(8L, &num);
				num = 0L;
				int num3;
				while (true)
				{
					if ((ulong)num > (ulong)(haystack_len - needle_len))
					{
						num3 = 2;
						break;
					}
					llvm_lifetime_start_p0.Invoke(8L, &num2);
					for (num2 = 0L; (ulong)num2 < (ulong)needle_len && (((_0_Invoke_w5uwa2.Invoke(comp, ((sbyte*)ptr)[num + num2], ((sbyte*)ptr2)[num2]) != 0) ? 1u : 0u) ^ 0xFFFFFFFFu) != 0; num2++)
					{
					}
					if (num2 == needle_len)
					{
						result = (byte*)ptr + num;
						num3 = 1;
					}
					else
					{
						num3 = 0;
					}
					llvm_lifetime_end_p0.Invoke(8L, &num2);
					switch (num3)
					{
					case 0:
						goto IL_0131;
					}
					break;
					IL_0131:
					num++;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num);
				if (num3 == 2)
				{
					result = null;
				}
				llvm_lifetime_end_p0.Invoke(8L, &ptr2);
				llvm_lifetime_end_p0.Invoke(8L, &ptr);
			}
			return result;
		}
	}
}
