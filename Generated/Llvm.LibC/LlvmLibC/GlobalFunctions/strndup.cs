using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strndup
{
	public unsafe static void* Invoke(void* src, long size)
	{
		long num = 0L;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		void* ptr = null;
		unchecked
		{
			void* result;
			if (src == null)
			{
				result = null;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num);
				num = unsigned_long_internal_string_length_char_char_const.Invoke(src);
				if ((ulong)num > (ulong)size)
				{
					num = size;
				}
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				*(sbyte*)(&anon_izyfb8) = -86;
				AllocChecker_AllocChecker.Invoke(&anon_izyfb8);
				llvm_lifetime_start_p0.Invoke(8L, &ptr);
				ptr = operator_new_unsigned_long_AllocChecker_y8sjvz.Invoke(num + 1L, &anon_izyfb8);
				if (!AllocChecker_operator_bool_const.Invoke(&anon_izyfb8))
				{
					result = null;
				}
				else
				{
					inline_memcpy_void_void_const_unsigned_long.Invoke(ptr, src, num + 1L);
					((sbyte*)ptr)[num] = 0;
					result = ptr;
				}
				llvm_lifetime_end_p0.Invoke(8L, &ptr);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
				llvm_lifetime_end_p0.Invoke(8L, &num);
			}
			return result;
		}
	}
}
